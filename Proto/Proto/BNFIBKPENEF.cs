using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNFIBKPENEF : IMessage<BNFIBKPENEF>, IMessage, IEquatable<BNFIBKPENEF>, IDeepCloneable<BNFIBKPENEF>, IBufferMessage
{
	public enum CJFBEONJIDLOneofCase
	{
		None = 0,
		LOLOEFOBOKA = 2,
		NANHFKEJMCJ = 11
	}

	private static readonly MessageParser<BNFIBKPENEF> _parser = new MessageParser<BNFIBKPENEF>(() => new BNFIBKPENEF());

	private UnknownFieldSet _unknownFields;

	public const int BOEFCCPBCDDFieldNumber = 4;

	private uint bOEFCCPBCDD_;

	public const int LOIJLIKOMJNFieldNumber = 15;

	private uint lOIJLIKOMJN_;

	public const int LOLOEFOBOKAFieldNumber = 2;

	public const int NANHFKEJMCJFieldNumber = 11;

	private object cJFBEONJIDL_;

	private CJFBEONJIDLOneofCase cJFBEONJIDLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNFIBKPENEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNFIBKPENEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOEFCCPBCDD
	{
		get
		{
			return bOEFCCPBCDD_;
		}
		set
		{
			bOEFCCPBCDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIJLIKOMJN
	{
		get
		{
			return lOIJLIKOMJN_;
		}
		set
		{
			lOIJLIKOMJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOLOEFOBOKA
	{
		get
		{
			if (!HasLOLOEFOBOKA)
			{
				return 0u;
			}
			return (uint)cJFBEONJIDL_;
		}
		set
		{
			cJFBEONJIDL_ = value;
			cJFBEONJIDLCase_ = CJFBEONJIDLOneofCase.LOLOEFOBOKA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLOLOEFOBOKA => cJFBEONJIDLCase_ == CJFBEONJIDLOneofCase.LOLOEFOBOKA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBOJACAEADL NANHFKEJMCJ
	{
		get
		{
			if (cJFBEONJIDLCase_ != CJFBEONJIDLOneofCase.NANHFKEJMCJ)
			{
				return null;
			}
			return (KBOJACAEADL)cJFBEONJIDL_;
		}
		set
		{
			cJFBEONJIDL_ = value;
			cJFBEONJIDLCase_ = ((value != null) ? CJFBEONJIDLOneofCase.NANHFKEJMCJ : CJFBEONJIDLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJFBEONJIDLOneofCase CJFBEONJIDLCase => cJFBEONJIDLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNFIBKPENEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNFIBKPENEF(BNFIBKPENEF other)
		: this()
	{
		bOEFCCPBCDD_ = other.bOEFCCPBCDD_;
		lOIJLIKOMJN_ = other.lOIJLIKOMJN_;
		switch (other.CJFBEONJIDLCase)
		{
		case CJFBEONJIDLOneofCase.LOLOEFOBOKA:
			LOLOEFOBOKA = other.LOLOEFOBOKA;
			break;
		case CJFBEONJIDLOneofCase.NANHFKEJMCJ:
			NANHFKEJMCJ = other.NANHFKEJMCJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNFIBKPENEF Clone()
	{
		return new BNFIBKPENEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLOLOEFOBOKA()
	{
		if (HasLOLOEFOBOKA)
		{
			ClearCJFBEONJIDL();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCJFBEONJIDL()
	{
		cJFBEONJIDLCase_ = CJFBEONJIDLOneofCase.None;
		cJFBEONJIDL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNFIBKPENEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNFIBKPENEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BOEFCCPBCDD != other.BOEFCCPBCDD)
		{
			return false;
		}
		if (LOIJLIKOMJN != other.LOIJLIKOMJN)
		{
			return false;
		}
		if (LOLOEFOBOKA != other.LOLOEFOBOKA)
		{
			return false;
		}
		if (!object.Equals(NANHFKEJMCJ, other.NANHFKEJMCJ))
		{
			return false;
		}
		if (CJFBEONJIDLCase != other.CJFBEONJIDLCase)
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
		if (BOEFCCPBCDD != 0)
		{
			num ^= BOEFCCPBCDD.GetHashCode();
		}
		if (LOIJLIKOMJN != 0)
		{
			num ^= LOIJLIKOMJN.GetHashCode();
		}
		if (HasLOLOEFOBOKA)
		{
			num ^= LOLOEFOBOKA.GetHashCode();
		}
		if (cJFBEONJIDLCase_ == CJFBEONJIDLOneofCase.NANHFKEJMCJ)
		{
			num ^= NANHFKEJMCJ.GetHashCode();
		}
		num ^= (int)cJFBEONJIDLCase_;
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
		if (HasLOLOEFOBOKA)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LOLOEFOBOKA);
		}
		if (BOEFCCPBCDD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BOEFCCPBCDD);
		}
		if (cJFBEONJIDLCase_ == CJFBEONJIDLOneofCase.NANHFKEJMCJ)
		{
			output.WriteRawTag(90);
			output.WriteMessage(NANHFKEJMCJ);
		}
		if (LOIJLIKOMJN != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LOIJLIKOMJN);
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
		if (BOEFCCPBCDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOEFCCPBCDD);
		}
		if (LOIJLIKOMJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIJLIKOMJN);
		}
		if (HasLOLOEFOBOKA)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOLOEFOBOKA);
		}
		if (cJFBEONJIDLCase_ == CJFBEONJIDLOneofCase.NANHFKEJMCJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NANHFKEJMCJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNFIBKPENEF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BOEFCCPBCDD != 0)
		{
			BOEFCCPBCDD = other.BOEFCCPBCDD;
		}
		if (other.LOIJLIKOMJN != 0)
		{
			LOIJLIKOMJN = other.LOIJLIKOMJN;
		}
		switch (other.CJFBEONJIDLCase)
		{
		case CJFBEONJIDLOneofCase.LOLOEFOBOKA:
			LOLOEFOBOKA = other.LOLOEFOBOKA;
			break;
		case CJFBEONJIDLOneofCase.NANHFKEJMCJ:
			if (NANHFKEJMCJ == null)
			{
				NANHFKEJMCJ = new KBOJACAEADL();
			}
			NANHFKEJMCJ.MergeFrom(other.NANHFKEJMCJ);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
				LOLOEFOBOKA = input.ReadUInt32();
				break;
			case 32u:
				BOEFCCPBCDD = input.ReadUInt32();
				break;
			case 90u:
			{
				KBOJACAEADL kBOJACAEADL = new KBOJACAEADL();
				if (cJFBEONJIDLCase_ == CJFBEONJIDLOneofCase.NANHFKEJMCJ)
				{
					kBOJACAEADL.MergeFrom(NANHFKEJMCJ);
				}
				input.ReadMessage(kBOJACAEADL);
				NANHFKEJMCJ = kBOJACAEADL;
				break;
			}
			case 120u:
				LOIJLIKOMJN = input.ReadUInt32();
				break;
			}
		}
	}
}
