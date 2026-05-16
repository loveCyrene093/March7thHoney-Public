using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ENENNMNEOGK : IMessage<ENENNMNEOGK>, IMessage, IEquatable<ENENNMNEOGK>, IDeepCloneable<ENENNMNEOGK>, IBufferMessage
{
	private static readonly MessageParser<ENENNMNEOGK> _parser = new MessageParser<ENENNMNEOGK>(() => new ENENNMNEOGK());

	private UnknownFieldSet _unknownFields;

	public const int OpTypeFieldNumber = 8;

	private IJKBLBJAABJ opType_;

	public const int NBIIMDABOPCFieldNumber = 10;

	private uint nBIIMDABOPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ENENNMNEOGK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ENENNMNEOGKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKBLBJAABJ OpType
	{
		get
		{
			return opType_;
		}
		set
		{
			opType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NBIIMDABOPC
	{
		get
		{
			return nBIIMDABOPC_;
		}
		set
		{
			nBIIMDABOPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENENNMNEOGK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENENNMNEOGK(ENENNMNEOGK other)
		: this()
	{
		opType_ = other.opType_;
		nBIIMDABOPC_ = other.nBIIMDABOPC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENENNMNEOGK Clone()
	{
		return new ENENNMNEOGK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ENENNMNEOGK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ENENNMNEOGK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (NBIIMDABOPC != other.NBIIMDABOPC)
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
		if (OpType != IJKBLBJAABJ.Pcpdhelpkem)
		{
			num ^= OpType.GetHashCode();
		}
		if (NBIIMDABOPC != 0)
		{
			num ^= NBIIMDABOPC.GetHashCode();
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
		if (OpType != IJKBLBJAABJ.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)OpType);
		}
		if (NBIIMDABOPC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NBIIMDABOPC);
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
		if (OpType != IJKBLBJAABJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OpType);
		}
		if (NBIIMDABOPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBIIMDABOPC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ENENNMNEOGK other)
	{
		if (other != null)
		{
			if (other.OpType != IJKBLBJAABJ.Pcpdhelpkem)
			{
				OpType = other.OpType;
			}
			if (other.NBIIMDABOPC != 0)
			{
				NBIIMDABOPC = other.NBIIMDABOPC;
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
			case 64u:
				OpType = (IJKBLBJAABJ)input.ReadEnum();
				break;
			case 80u:
				NBIIMDABOPC = input.ReadUInt32();
				break;
			}
		}
	}
}
