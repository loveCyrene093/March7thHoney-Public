using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JABFAOAIEIG : IMessage<JABFAOAIEIG>, IMessage, IEquatable<JABFAOAIEIG>, IDeepCloneable<JABFAOAIEIG>, IBufferMessage
{
	private static readonly MessageParser<JABFAOAIEIG> _parser = new MessageParser<JABFAOAIEIG>(() => new JABFAOAIEIG());

	private UnknownFieldSet _unknownFields;

	public const int NOKBKAIOKFEFieldNumber = 8;

	private uint nOKBKAIOKFE_;

	public const int CNDKAPOIEOJFieldNumber = 10;

	private bool cNDKAPOIEOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JABFAOAIEIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JABFAOAIEIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOKBKAIOKFE
	{
		get
		{
			return nOKBKAIOKFE_;
		}
		set
		{
			nOKBKAIOKFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CNDKAPOIEOJ
	{
		get
		{
			return cNDKAPOIEOJ_;
		}
		set
		{
			cNDKAPOIEOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JABFAOAIEIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JABFAOAIEIG(JABFAOAIEIG other)
		: this()
	{
		nOKBKAIOKFE_ = other.nOKBKAIOKFE_;
		cNDKAPOIEOJ_ = other.cNDKAPOIEOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JABFAOAIEIG Clone()
	{
		return new JABFAOAIEIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JABFAOAIEIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JABFAOAIEIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NOKBKAIOKFE != other.NOKBKAIOKFE)
		{
			return false;
		}
		if (CNDKAPOIEOJ != other.CNDKAPOIEOJ)
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
		if (NOKBKAIOKFE != 0)
		{
			num ^= NOKBKAIOKFE.GetHashCode();
		}
		if (CNDKAPOIEOJ)
		{
			num ^= CNDKAPOIEOJ.GetHashCode();
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
		if (NOKBKAIOKFE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NOKBKAIOKFE);
		}
		if (CNDKAPOIEOJ)
		{
			output.WriteRawTag(80);
			output.WriteBool(CNDKAPOIEOJ);
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
		if (NOKBKAIOKFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOKBKAIOKFE);
		}
		if (CNDKAPOIEOJ)
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
	public void MergeFrom(JABFAOAIEIG other)
	{
		if (other != null)
		{
			if (other.NOKBKAIOKFE != 0)
			{
				NOKBKAIOKFE = other.NOKBKAIOKFE;
			}
			if (other.CNDKAPOIEOJ)
			{
				CNDKAPOIEOJ = other.CNDKAPOIEOJ;
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
				NOKBKAIOKFE = input.ReadUInt32();
				break;
			case 80u:
				CNDKAPOIEOJ = input.ReadBool();
				break;
			}
		}
	}
}
