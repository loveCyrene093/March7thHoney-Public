using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HEHGNIICKAA : IMessage<HEHGNIICKAA>, IMessage, IEquatable<HEHGNIICKAA>, IDeepCloneable<HEHGNIICKAA>, IBufferMessage
{
	private static readonly MessageParser<HEHGNIICKAA> _parser = new MessageParser<HEHGNIICKAA>(() => new HEHGNIICKAA());

	private UnknownFieldSet _unknownFields;

	public const int AKIFPPJCNACFieldNumber = 1;

	private ByteString aKIFPPJCNAC_ = ByteString.Empty;

	public const int GJJPEPBPCKMFieldNumber = 14;

	private uint gJJPEPBPCKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HEHGNIICKAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HEHGNIICKAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString AKIFPPJCNAC
	{
		get
		{
			return aKIFPPJCNAC_;
		}
		set
		{
			aKIFPPJCNAC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJJPEPBPCKM
	{
		get
		{
			return gJJPEPBPCKM_;
		}
		set
		{
			gJJPEPBPCKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHGNIICKAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHGNIICKAA(HEHGNIICKAA other)
		: this()
	{
		aKIFPPJCNAC_ = other.aKIFPPJCNAC_;
		gJJPEPBPCKM_ = other.gJJPEPBPCKM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHGNIICKAA Clone()
	{
		return new HEHGNIICKAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HEHGNIICKAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HEHGNIICKAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AKIFPPJCNAC != other.AKIFPPJCNAC)
		{
			return false;
		}
		if (GJJPEPBPCKM != other.GJJPEPBPCKM)
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
		if (AKIFPPJCNAC.Length != 0)
		{
			num ^= AKIFPPJCNAC.GetHashCode();
		}
		if (GJJPEPBPCKM != 0)
		{
			num ^= GJJPEPBPCKM.GetHashCode();
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
		if (AKIFPPJCNAC.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(AKIFPPJCNAC);
		}
		if (GJJPEPBPCKM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GJJPEPBPCKM);
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
		if (AKIFPPJCNAC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AKIFPPJCNAC);
		}
		if (GJJPEPBPCKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJJPEPBPCKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HEHGNIICKAA other)
	{
		if (other != null)
		{
			if (other.AKIFPPJCNAC.Length != 0)
			{
				AKIFPPJCNAC = other.AKIFPPJCNAC;
			}
			if (other.GJJPEPBPCKM != 0)
			{
				GJJPEPBPCKM = other.GJJPEPBPCKM;
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
			case 10u:
				AKIFPPJCNAC = input.ReadBytes();
				break;
			case 112u:
				GJJPEPBPCKM = input.ReadUInt32();
				break;
			}
		}
	}
}
