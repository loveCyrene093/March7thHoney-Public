using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCNLHLLIAPL : IMessage<CCNLHLLIAPL>, IMessage, IEquatable<CCNLHLLIAPL>, IDeepCloneable<CCNLHLLIAPL>, IBufferMessage
{
	public enum HDACCIEIJFOOneofCase
	{
		None = 0,
		FLJNDFMGDBI = 853,
		HAINJKLLLKF = 955
	}

	private static readonly MessageParser<CCNLHLLIAPL> _parser = new MessageParser<CCNLHLLIAPL>(() => new CCNLHLLIAPL());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 3;

	private uint traitId_;

	public const int EffectIdFieldNumber = 12;

	private uint effectId_;

	public const int FLJNDFMGDBIFieldNumber = 853;

	public const int HAINJKLLLKFFieldNumber = 955;

	private object hDACCIEIJFO_;

	private HDACCIEIJFOOneofCase hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCNLHLLIAPL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCNLHLLIAPLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAJAENKKBP FLJNDFMGDBI
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.FLJNDFMGDBI)
			{
				return null;
			}
			return (DFAJAENKKBP)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.FLJNDFMGDBI : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJMMKFHJPHJ HAINJKLLLKF
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.HAINJKLLLKF)
			{
				return null;
			}
			return (CJMMKFHJPHJ)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.HAINJKLLLKF : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDACCIEIJFOOneofCase HDACCIEIJFOCase => hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNLHLLIAPL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNLHLLIAPL(CCNLHLLIAPL other)
		: this()
	{
		traitId_ = other.traitId_;
		effectId_ = other.effectId_;
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.FLJNDFMGDBI:
			FLJNDFMGDBI = other.FLJNDFMGDBI.Clone();
			break;
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			HAINJKLLLKF = other.HAINJKLLLKF.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNLHLLIAPL Clone()
	{
		return new CCNLHLLIAPL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHDACCIEIJFO()
	{
		hDACCIEIJFOCase_ = HDACCIEIJFOOneofCase.None;
		hDACCIEIJFO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCNLHLLIAPL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCNLHLLIAPL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (!object.Equals(FLJNDFMGDBI, other.FLJNDFMGDBI))
		{
			return false;
		}
		if (!object.Equals(HAINJKLLLKF, other.HAINJKLLLKF))
		{
			return false;
		}
		if (HDACCIEIJFOCase != other.HDACCIEIJFOCase)
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.FLJNDFMGDBI)
		{
			num ^= FLJNDFMGDBI.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num ^= HAINJKLLLKF.GetHashCode();
		}
		num ^= (int)hDACCIEIJFOCase_;
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
		if (TraitId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TraitId);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EffectId);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.FLJNDFMGDBI)
		{
			output.WriteRawTag(170, 53);
			output.WriteMessage(FLJNDFMGDBI);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			output.WriteRawTag(218, 59);
			output.WriteMessage(HAINJKLLLKF);
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.FLJNDFMGDBI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FLJNDFMGDBI);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HAINJKLLLKF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCNLHLLIAPL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TraitId != 0)
		{
			TraitId = other.TraitId;
		}
		if (other.EffectId != 0)
		{
			EffectId = other.EffectId;
		}
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.FLJNDFMGDBI:
			if (FLJNDFMGDBI == null)
			{
				FLJNDFMGDBI = new DFAJAENKKBP();
			}
			FLJNDFMGDBI.MergeFrom(other.FLJNDFMGDBI);
			break;
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			if (HAINJKLLLKF == null)
			{
				HAINJKLLLKF = new CJMMKFHJPHJ();
			}
			HAINJKLLLKF.MergeFrom(other.HAINJKLLLKF);
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
			case 24u:
				TraitId = input.ReadUInt32();
				break;
			case 96u:
				EffectId = input.ReadUInt32();
				break;
			case 6826u:
			{
				DFAJAENKKBP dFAJAENKKBP = new DFAJAENKKBP();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.FLJNDFMGDBI)
				{
					dFAJAENKKBP.MergeFrom(FLJNDFMGDBI);
				}
				input.ReadMessage(dFAJAENKKBP);
				FLJNDFMGDBI = dFAJAENKKBP;
				break;
			}
			case 7642u:
			{
				CJMMKFHJPHJ cJMMKFHJPHJ = new CJMMKFHJPHJ();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
				{
					cJMMKFHJPHJ.MergeFrom(HAINJKLLLKF);
				}
				input.ReadMessage(cJMMKFHJPHJ);
				HAINJKLLLKF = cJMMKFHJPHJ;
				break;
			}
			}
		}
	}
}
