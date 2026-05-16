using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAPBJANOPLP : IMessage<BAPBJANOPLP>, IMessage, IEquatable<BAPBJANOPLP>, IDeepCloneable<BAPBJANOPLP>, IBufferMessage
{
	private static readonly MessageParser<BAPBJANOPLP> _parser = new MessageParser<BAPBJANOPLP>(() => new BAPBJANOPLP());

	private UnknownFieldSet _unknownFields;

	public const int CPKMCPFIBLDFieldNumber = 11;

	private uint cPKMCPFIBLD_;

	public const int AFNEPLKIHLLFieldNumber = 14;

	private uint aFNEPLKIHLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAPBJANOPLP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAPBJANOPLPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPKMCPFIBLD
	{
		get
		{
			return cPKMCPFIBLD_;
		}
		set
		{
			cPKMCPFIBLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFNEPLKIHLL
	{
		get
		{
			return aFNEPLKIHLL_;
		}
		set
		{
			aFNEPLKIHLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAPBJANOPLP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAPBJANOPLP(BAPBJANOPLP other)
		: this()
	{
		cPKMCPFIBLD_ = other.cPKMCPFIBLD_;
		aFNEPLKIHLL_ = other.aFNEPLKIHLL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAPBJANOPLP Clone()
	{
		return new BAPBJANOPLP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAPBJANOPLP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAPBJANOPLP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CPKMCPFIBLD != other.CPKMCPFIBLD)
		{
			return false;
		}
		if (AFNEPLKIHLL != other.AFNEPLKIHLL)
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
		if (CPKMCPFIBLD != 0)
		{
			num ^= CPKMCPFIBLD.GetHashCode();
		}
		if (AFNEPLKIHLL != 0)
		{
			num ^= AFNEPLKIHLL.GetHashCode();
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
		if (CPKMCPFIBLD != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CPKMCPFIBLD);
		}
		if (AFNEPLKIHLL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AFNEPLKIHLL);
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
		if (CPKMCPFIBLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPKMCPFIBLD);
		}
		if (AFNEPLKIHLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFNEPLKIHLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAPBJANOPLP other)
	{
		if (other != null)
		{
			if (other.CPKMCPFIBLD != 0)
			{
				CPKMCPFIBLD = other.CPKMCPFIBLD;
			}
			if (other.AFNEPLKIHLL != 0)
			{
				AFNEPLKIHLL = other.AFNEPLKIHLL;
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
			case 88u:
				CPKMCPFIBLD = input.ReadUInt32();
				break;
			case 112u:
				AFNEPLKIHLL = input.ReadUInt32();
				break;
			}
		}
	}
}
