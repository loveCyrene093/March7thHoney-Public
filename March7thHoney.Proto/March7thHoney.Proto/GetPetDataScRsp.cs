using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPetDataScRsp : IMessage<GetPetDataScRsp>, IMessage, IEquatable<GetPetDataScRsp>, IDeepCloneable<GetPetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPetDataScRsp> _parser = new MessageParser<GetPetDataScRsp>(() => new GetPetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurPetIdFieldNumber = 1;

	private uint curPetId_;

	public const int UnlockedPetIdFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_unlockedPetId_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> unlockedPetId_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurPetId
	{
		get
		{
			return curPetId_;
		}
		set
		{
			curPetId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockedPetId => unlockedPetId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPetDataScRsp(GetPetDataScRsp other)
		: this()
	{
		curPetId_ = other.curPetId_;
		unlockedPetId_ = other.unlockedPetId_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPetDataScRsp Clone()
	{
		return new GetPetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurPetId != other.CurPetId)
		{
			return false;
		}
		if (!unlockedPetId_.Equals(other.unlockedPetId_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (CurPetId != 0)
		{
			num ^= CurPetId.GetHashCode();
		}
		num ^= unlockedPetId_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CurPetId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurPetId);
		}
		unlockedPetId_.WriteTo(ref output, _repeated_unlockedPetId_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (CurPetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPetId);
		}
		num += unlockedPetId_.CalculateSize(_repeated_unlockedPetId_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPetDataScRsp other)
	{
		if (other != null)
		{
			if (other.CurPetId != 0)
			{
				CurPetId = other.CurPetId;
			}
			unlockedPetId_.Add(other.unlockedPetId_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				CurPetId = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				unlockedPetId_.AddEntriesFrom(ref input, _repeated_unlockedPetId_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
