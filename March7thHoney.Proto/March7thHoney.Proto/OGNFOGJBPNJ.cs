using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGNFOGJBPNJ : IMessage<OGNFOGJBPNJ>, IMessage, IEquatable<OGNFOGJBPNJ>, IDeepCloneable<OGNFOGJBPNJ>, IBufferMessage
{
	private static readonly MessageParser<OGNFOGJBPNJ> _parser = new MessageParser<OGNFOGJBPNJ>(() => new OGNFOGJBPNJ());

	private UnknownFieldSet _unknownFields;

	public const int CEBPAJAAJPPFieldNumber = 5;

	private bool cEBPAJAAJPP_;

	public const int ABHHNNKBAFPFieldNumber = 10;

	private uint aBHHNNKBAFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGNFOGJBPNJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGNFOGJBPNJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public OGNFOGJBPNJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNFOGJBPNJ(OGNFOGJBPNJ other)
		: this()
	{
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		aBHHNNKBAFP_ = other.aBHHNNKBAFP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNFOGJBPNJ Clone()
	{
		return new OGNFOGJBPNJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGNFOGJBPNJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGNFOGJBPNJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
		{
			return false;
		}
		if (ABHHNNKBAFP != other.ABHHNNKBAFP)
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
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
		}
		if (ABHHNNKBAFP != 0)
		{
			num ^= ABHHNNKBAFP.GetHashCode();
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
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(40);
			output.WriteBool(CEBPAJAAJPP);
		}
		if (ABHHNNKBAFP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ABHHNNKBAFP);
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
		if (CEBPAJAAJPP)
		{
			num += 2;
		}
		if (ABHHNNKBAFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABHHNNKBAFP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGNFOGJBPNJ other)
	{
		if (other != null)
		{
			if (other.CEBPAJAAJPP)
			{
				CEBPAJAAJPP = other.CEBPAJAAJPP;
			}
			if (other.ABHHNNKBAFP != 0)
			{
				ABHHNNKBAFP = other.ABHHNNKBAFP;
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
				CEBPAJAAJPP = input.ReadBool();
				break;
			case 80u:
				ABHHNNKBAFP = input.ReadUInt32();
				break;
			}
		}
	}
}
