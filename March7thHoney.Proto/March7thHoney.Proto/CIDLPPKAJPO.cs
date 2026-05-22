using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIDLPPKAJPO : IMessage<CIDLPPKAJPO>, IMessage, IEquatable<CIDLPPKAJPO>, IDeepCloneable<CIDLPPKAJPO>, IBufferMessage
{
	public enum IHCIAHIFPLLOneofCase
	{
		None = 0,
		LGJHGODNJGM = 3,
		HGPIGGLBFMM = 11
	}

	private static readonly MessageParser<CIDLPPKAJPO> _parser = new MessageParser<CIDLPPKAJPO>(() => new CIDLPPKAJPO());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 10;

	private uint uniqueId_;

	public const int CardIdFieldNumber = 14;

	private uint cardId_;

	public const int LGJHGODNJGMFieldNumber = 3;

	public const int HGPIGGLBFMMFieldNumber = 11;

	private object iHCIAHIFPLL_;

	private IHCIAHIFPLLOneofCase iHCIAHIFPLLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIDLPPKAJPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIDLPPKAJPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CardId
	{
		get
		{
			return cardId_;
		}
		set
		{
			cardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AACDBCKAFCA LGJHGODNJGM
	{
		get
		{
			if (iHCIAHIFPLLCase_ != IHCIAHIFPLLOneofCase.LGJHGODNJGM)
			{
				return null;
			}
			return (AACDBCKAFCA)iHCIAHIFPLL_;
		}
		set
		{
			iHCIAHIFPLL_ = value;
			iHCIAHIFPLLCase_ = ((value != null) ? IHCIAHIFPLLOneofCase.LGJHGODNJGM : IHCIAHIFPLLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBKANLBCCP HGPIGGLBFMM
	{
		get
		{
			if (iHCIAHIFPLLCase_ != IHCIAHIFPLLOneofCase.HGPIGGLBFMM)
			{
				return null;
			}
			return (HHBKANLBCCP)iHCIAHIFPLL_;
		}
		set
		{
			iHCIAHIFPLL_ = value;
			iHCIAHIFPLLCase_ = ((value != null) ? IHCIAHIFPLLOneofCase.HGPIGGLBFMM : IHCIAHIFPLLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHCIAHIFPLLOneofCase IHCIAHIFPLLCase => iHCIAHIFPLLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIDLPPKAJPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIDLPPKAJPO(CIDLPPKAJPO other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		cardId_ = other.cardId_;
		switch (other.IHCIAHIFPLLCase)
		{
		case IHCIAHIFPLLOneofCase.LGJHGODNJGM:
			LGJHGODNJGM = other.LGJHGODNJGM.Clone();
			break;
		case IHCIAHIFPLLOneofCase.HGPIGGLBFMM:
			HGPIGGLBFMM = other.HGPIGGLBFMM.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIDLPPKAJPO Clone()
	{
		return new CIDLPPKAJPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIHCIAHIFPLL()
	{
		iHCIAHIFPLLCase_ = IHCIAHIFPLLOneofCase.None;
		iHCIAHIFPLL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIDLPPKAJPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIDLPPKAJPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (CardId != other.CardId)
		{
			return false;
		}
		if (!object.Equals(LGJHGODNJGM, other.LGJHGODNJGM))
		{
			return false;
		}
		if (!object.Equals(HGPIGGLBFMM, other.HGPIGGLBFMM))
		{
			return false;
		}
		if (IHCIAHIFPLLCase != other.IHCIAHIFPLLCase)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
		}
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.LGJHGODNJGM)
		{
			num ^= LGJHGODNJGM.GetHashCode();
		}
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.HGPIGGLBFMM)
		{
			num ^= HGPIGGLBFMM.GetHashCode();
		}
		num ^= (int)iHCIAHIFPLLCase_;
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
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.LGJHGODNJGM)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LGJHGODNJGM);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(UniqueId);
		}
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.HGPIGGLBFMM)
		{
			output.WriteRawTag(90);
			output.WriteMessage(HGPIGGLBFMM);
		}
		if (CardId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CardId);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CardId);
		}
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.LGJHGODNJGM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LGJHGODNJGM);
		}
		if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.HGPIGGLBFMM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HGPIGGLBFMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIDLPPKAJPO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.CardId != 0)
		{
			CardId = other.CardId;
		}
		switch (other.IHCIAHIFPLLCase)
		{
		case IHCIAHIFPLLOneofCase.LGJHGODNJGM:
			if (LGJHGODNJGM == null)
			{
				LGJHGODNJGM = new AACDBCKAFCA();
			}
			LGJHGODNJGM.MergeFrom(other.LGJHGODNJGM);
			break;
		case IHCIAHIFPLLOneofCase.HGPIGGLBFMM:
			if (HGPIGGLBFMM == null)
			{
				HGPIGGLBFMM = new HHBKANLBCCP();
			}
			HGPIGGLBFMM.MergeFrom(other.HGPIGGLBFMM);
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
			case 26u:
			{
				AACDBCKAFCA aACDBCKAFCA = new AACDBCKAFCA();
				if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.LGJHGODNJGM)
				{
					aACDBCKAFCA.MergeFrom(LGJHGODNJGM);
				}
				input.ReadMessage(aACDBCKAFCA);
				LGJHGODNJGM = aACDBCKAFCA;
				break;
			}
			case 80u:
				UniqueId = input.ReadUInt32();
				break;
			case 90u:
			{
				HHBKANLBCCP hHBKANLBCCP = new HHBKANLBCCP();
				if (iHCIAHIFPLLCase_ == IHCIAHIFPLLOneofCase.HGPIGGLBFMM)
				{
					hHBKANLBCCP.MergeFrom(HGPIGGLBFMM);
				}
				input.ReadMessage(hHBKANLBCCP);
				HGPIGGLBFMM = hHBKANLBCCP;
				break;
			}
			case 112u:
				CardId = input.ReadUInt32();
				break;
			}
		}
	}
}
