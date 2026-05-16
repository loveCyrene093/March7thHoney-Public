using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOJCNLNIBBH : IMessage<NOJCNLNIBBH>, IMessage, IEquatable<NOJCNLNIBBH>, IDeepCloneable<NOJCNLNIBBH>, IBufferMessage
{
	private static readonly MessageParser<NOJCNLNIBBH> _parser = new MessageParser<NOJCNLNIBBH>(() => new NOJCNLNIBBH());

	private UnknownFieldSet _unknownFields;

	public const int LBEIHILHOKMFieldNumber = 5;

	private uint lBEIHILHOKM_;

	public const int ItemValueFieldNumber = 9;

	private uint itemValue_;

	public const int BKILELBILBOFieldNumber = 12;

	private uint bKILELBILBO_;

	public const int NONKHEMLDNOFieldNumber = 13;

	private uint nONKHEMLDNO_;

	public const int IOJLMOCPAPGFieldNumber = 14;

	private bool iOJLMOCPAPG_;

	public const int DMBGFLADNHAFieldNumber = 15;

	private bool dMBGFLADNHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOJCNLNIBBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOJCNLNIBBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBEIHILHOKM
	{
		get
		{
			return lBEIHILHOKM_;
		}
		set
		{
			lBEIHILHOKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKILELBILBO
	{
		get
		{
			return bKILELBILBO_;
		}
		set
		{
			bKILELBILBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NONKHEMLDNO
	{
		get
		{
			return nONKHEMLDNO_;
		}
		set
		{
			nONKHEMLDNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IOJLMOCPAPG
	{
		get
		{
			return iOJLMOCPAPG_;
		}
		set
		{
			iOJLMOCPAPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DMBGFLADNHA
	{
		get
		{
			return dMBGFLADNHA_;
		}
		set
		{
			dMBGFLADNHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJCNLNIBBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJCNLNIBBH(NOJCNLNIBBH other)
		: this()
	{
		lBEIHILHOKM_ = other.lBEIHILHOKM_;
		itemValue_ = other.itemValue_;
		bKILELBILBO_ = other.bKILELBILBO_;
		nONKHEMLDNO_ = other.nONKHEMLDNO_;
		iOJLMOCPAPG_ = other.iOJLMOCPAPG_;
		dMBGFLADNHA_ = other.dMBGFLADNHA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJCNLNIBBH Clone()
	{
		return new NOJCNLNIBBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOJCNLNIBBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOJCNLNIBBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBEIHILHOKM != other.LBEIHILHOKM)
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (BKILELBILBO != other.BKILELBILBO)
		{
			return false;
		}
		if (NONKHEMLDNO != other.NONKHEMLDNO)
		{
			return false;
		}
		if (IOJLMOCPAPG != other.IOJLMOCPAPG)
		{
			return false;
		}
		if (DMBGFLADNHA != other.DMBGFLADNHA)
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
		if (LBEIHILHOKM != 0)
		{
			num ^= LBEIHILHOKM.GetHashCode();
		}
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (BKILELBILBO != 0)
		{
			num ^= BKILELBILBO.GetHashCode();
		}
		if (NONKHEMLDNO != 0)
		{
			num ^= NONKHEMLDNO.GetHashCode();
		}
		if (IOJLMOCPAPG)
		{
			num ^= IOJLMOCPAPG.GetHashCode();
		}
		if (DMBGFLADNHA)
		{
			num ^= DMBGFLADNHA.GetHashCode();
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
		if (LBEIHILHOKM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LBEIHILHOKM);
		}
		if (ItemValue != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ItemValue);
		}
		if (BKILELBILBO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BKILELBILBO);
		}
		if (NONKHEMLDNO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NONKHEMLDNO);
		}
		if (IOJLMOCPAPG)
		{
			output.WriteRawTag(112);
			output.WriteBool(IOJLMOCPAPG);
		}
		if (DMBGFLADNHA)
		{
			output.WriteRawTag(120);
			output.WriteBool(DMBGFLADNHA);
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
		if (LBEIHILHOKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBEIHILHOKM);
		}
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (BKILELBILBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKILELBILBO);
		}
		if (NONKHEMLDNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NONKHEMLDNO);
		}
		if (IOJLMOCPAPG)
		{
			num += 2;
		}
		if (DMBGFLADNHA)
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
	public void MergeFrom(NOJCNLNIBBH other)
	{
		if (other != null)
		{
			if (other.LBEIHILHOKM != 0)
			{
				LBEIHILHOKM = other.LBEIHILHOKM;
			}
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.BKILELBILBO != 0)
			{
				BKILELBILBO = other.BKILELBILBO;
			}
			if (other.NONKHEMLDNO != 0)
			{
				NONKHEMLDNO = other.NONKHEMLDNO;
			}
			if (other.IOJLMOCPAPG)
			{
				IOJLMOCPAPG = other.IOJLMOCPAPG;
			}
			if (other.DMBGFLADNHA)
			{
				DMBGFLADNHA = other.DMBGFLADNHA;
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
				LBEIHILHOKM = input.ReadUInt32();
				break;
			case 72u:
				ItemValue = input.ReadUInt32();
				break;
			case 96u:
				BKILELBILBO = input.ReadUInt32();
				break;
			case 104u:
				NONKHEMLDNO = input.ReadUInt32();
				break;
			case 112u:
				IOJLMOCPAPG = input.ReadBool();
				break;
			case 120u:
				DMBGFLADNHA = input.ReadBool();
				break;
			}
		}
	}
}
