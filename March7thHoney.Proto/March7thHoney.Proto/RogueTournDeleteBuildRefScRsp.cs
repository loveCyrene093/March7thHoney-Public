using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournDeleteBuildRefScRsp : IMessage<RogueTournDeleteBuildRefScRsp>, IMessage, IEquatable<RogueTournDeleteBuildRefScRsp>, IDeepCloneable<RogueTournDeleteBuildRefScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournDeleteBuildRefScRsp> _parser = new MessageParser<RogueTournDeleteBuildRefScRsp>(() => new RogueTournDeleteBuildRefScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IBJMBIACFEKFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournDeleteBuildRefScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournDeleteBuildRefScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

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
	public RogueTournDeleteBuildRefScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournDeleteBuildRefScRsp(RogueTournDeleteBuildRefScRsp other)
		: this()
	{
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournDeleteBuildRefScRsp Clone()
	{
		return new RogueTournDeleteBuildRefScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournDeleteBuildRefScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournDeleteBuildRefScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
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
		num ^= iBJMBIACFEK_.GetHashCode();
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
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
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
	public void MergeFrom(RogueTournDeleteBuildRefScRsp other)
	{
		if (other != null)
		{
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
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
			case 10u:
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
