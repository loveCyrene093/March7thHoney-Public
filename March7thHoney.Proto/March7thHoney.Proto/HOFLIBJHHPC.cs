using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HOFLIBJHHPC : IMessage<HOFLIBJHHPC>, IMessage, IEquatable<HOFLIBJHHPC>, IDeepCloneable<HOFLIBJHHPC>, IBufferMessage
{
	private static readonly MessageParser<HOFLIBJHHPC> _parser = new MessageParser<HOFLIBJHHPC>(() => new HOFLIBJHHPC());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int CHDPNCOHAGHFieldNumber = 2;

	private uint cHDPNCOHAGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HOFLIBJHHPC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HOFLIBJHHPCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHDPNCOHAGH
	{
		get
		{
			return cHDPNCOHAGH_;
		}
		set
		{
			cHDPNCOHAGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOFLIBJHHPC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOFLIBJHHPC(HOFLIBJHHPC other)
		: this()
	{
		avatarIdList_ = other.avatarIdList_.Clone();
		cHDPNCOHAGH_ = other.cHDPNCOHAGH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOFLIBJHHPC Clone()
	{
		return new HOFLIBJHHPC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HOFLIBJHHPC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HOFLIBJHHPC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (CHDPNCOHAGH != other.CHDPNCOHAGH)
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
		num ^= avatarIdList_.GetHashCode();
		if (CHDPNCOHAGH != 0)
		{
			num ^= CHDPNCOHAGH.GetHashCode();
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
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		if (CHDPNCOHAGH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CHDPNCOHAGH);
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
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (CHDPNCOHAGH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHDPNCOHAGH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HOFLIBJHHPC other)
	{
		if (other != null)
		{
			avatarIdList_.Add(other.avatarIdList_);
			if (other.CHDPNCOHAGH != 0)
			{
				CHDPNCOHAGH = other.CHDPNCOHAGH;
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
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 16u:
				CHDPNCOHAGH = input.ReadUInt32();
				break;
			}
		}
	}
}
