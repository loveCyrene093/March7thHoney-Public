using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NDPGKDLGBFB : IMessage<NDPGKDLGBFB>, IMessage, IEquatable<NDPGKDLGBFB>, IDeepCloneable<NDPGKDLGBFB>, IBufferMessage
{
	private static readonly MessageParser<NDPGKDLGBFB> _parser = new MessageParser<NDPGKDLGBFB>(() => new NDPGKDLGBFB());

	private UnknownFieldSet _unknownFields;

	public const int ABHHNNKBAFPFieldNumber = 5;

	private uint aBHHNNKBAFP_;

	public const int CEBPAJAAJPPFieldNumber = 11;

	private bool cEBPAJAAJPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NDPGKDLGBFB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NDPGKDLGBFBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABHHNNKBAFP
	{
		get
		{
			return aBHHNNKBAFP_;
		}
		set
		{
			aBHHNNKBAFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CEBPAJAAJPP
	{
		get
		{
			return cEBPAJAAJPP_;
		}
		set
		{
			cEBPAJAAJPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDPGKDLGBFB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDPGKDLGBFB(NDPGKDLGBFB other)
		: this()
	{
		aBHHNNKBAFP_ = other.aBHHNNKBAFP_;
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDPGKDLGBFB Clone()
	{
		return new NDPGKDLGBFB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NDPGKDLGBFB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NDPGKDLGBFB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ABHHNNKBAFP != other.ABHHNNKBAFP)
		{
			return false;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
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
		if (ABHHNNKBAFP != 0)
		{
			num ^= ABHHNNKBAFP.GetHashCode();
		}
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
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
		if (ABHHNNKBAFP != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ABHHNNKBAFP);
		}
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(88);
			output.WriteBool(CEBPAJAAJPP);
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
		if (ABHHNNKBAFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABHHNNKBAFP);
		}
		if (CEBPAJAAJPP)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NDPGKDLGBFB other)
	{
		if (other != null)
		{
			if (other.ABHHNNKBAFP != 0)
			{
				ABHHNNKBAFP = other.ABHHNNKBAFP;
			}
			if (other.CEBPAJAAJPP)
			{
				CEBPAJAAJPP = other.CEBPAJAAJPP;
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
			case 40u:
				ABHHNNKBAFP = input.ReadUInt32();
				break;
			case 88u:
				CEBPAJAAJPP = input.ReadBool();
				break;
			}
		}
	}
}
