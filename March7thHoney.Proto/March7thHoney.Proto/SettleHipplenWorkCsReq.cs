using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SettleHipplenWorkCsReq : IMessage<SettleHipplenWorkCsReq>, IMessage, IEquatable<SettleHipplenWorkCsReq>, IDeepCloneable<SettleHipplenWorkCsReq>, IBufferMessage
{
	public enum HDACCIEIJFOOneofCase
	{
		None = 0,
		PGJIAGGHBBA = 2,
		MNIMAFBIGGP = 3,
		PPJOJOKOOBF = 10,
		BJGDFMJDJMH = 13
	}

	private static readonly MessageParser<SettleHipplenWorkCsReq> _parser = new MessageParser<SettleHipplenWorkCsReq>(() => new SettleHipplenWorkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PGJIAGGHBBAFieldNumber = 2;

	public const int MNIMAFBIGGPFieldNumber = 3;

	public const int PPJOJOKOOBFFieldNumber = 10;

	public const int BJGDFMJDJMHFieldNumber = 13;

	private object hDACCIEIJFO_;

	private HDACCIEIJFOOneofCase hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SettleHipplenWorkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SettleHipplenWorkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJEAIHMINMJ PGJIAGGHBBA
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.PGJIAGGHBBA)
			{
				return null;
			}
			return (CJEAIHMINMJ)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.PGJIAGGHBBA : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCIMHEMJDD MNIMAFBIGGP
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.MNIMAFBIGGP)
			{
				return null;
			}
			return (ONCIMHEMJDD)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.MNIMAFBIGGP : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJOLPAEPBDN PPJOJOKOOBF
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.PPJOJOKOOBF)
			{
				return null;
			}
			return (OJOLPAEPBDN)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.PPJOJOKOOBF : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJBGALBCAEG BJGDFMJDJMH
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.BJGDFMJDJMH)
			{
				return null;
			}
			return (KJBGALBCAEG)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.BJGDFMJDJMH : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDACCIEIJFOOneofCase HDACCIEIJFOCase => hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkCsReq(SettleHipplenWorkCsReq other)
		: this()
	{
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.PGJIAGGHBBA:
			PGJIAGGHBBA = other.PGJIAGGHBBA.Clone();
			break;
		case HDACCIEIJFOOneofCase.MNIMAFBIGGP:
			MNIMAFBIGGP = other.MNIMAFBIGGP.Clone();
			break;
		case HDACCIEIJFOOneofCase.PPJOJOKOOBF:
			PPJOJOKOOBF = other.PPJOJOKOOBF.Clone();
			break;
		case HDACCIEIJFOOneofCase.BJGDFMJDJMH:
			BJGDFMJDJMH = other.BJGDFMJDJMH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkCsReq Clone()
	{
		return new SettleHipplenWorkCsReq(this);
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
		return Equals(other as SettleHipplenWorkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SettleHipplenWorkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PGJIAGGHBBA, other.PGJIAGGHBBA))
		{
			return false;
		}
		if (!object.Equals(MNIMAFBIGGP, other.MNIMAFBIGGP))
		{
			return false;
		}
		if (!object.Equals(PPJOJOKOOBF, other.PPJOJOKOOBF))
		{
			return false;
		}
		if (!object.Equals(BJGDFMJDJMH, other.BJGDFMJDJMH))
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PGJIAGGHBBA)
		{
			num ^= PGJIAGGHBBA.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.MNIMAFBIGGP)
		{
			num ^= MNIMAFBIGGP.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PPJOJOKOOBF)
		{
			num ^= PPJOJOKOOBF.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.BJGDFMJDJMH)
		{
			num ^= BJGDFMJDJMH.GetHashCode();
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PGJIAGGHBBA)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PGJIAGGHBBA);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.MNIMAFBIGGP)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MNIMAFBIGGP);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PPJOJOKOOBF)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PPJOJOKOOBF);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.BJGDFMJDJMH)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BJGDFMJDJMH);
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PGJIAGGHBBA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PGJIAGGHBBA);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.MNIMAFBIGGP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNIMAFBIGGP);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PPJOJOKOOBF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPJOJOKOOBF);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.BJGDFMJDJMH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BJGDFMJDJMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SettleHipplenWorkCsReq other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.PGJIAGGHBBA:
			if (PGJIAGGHBBA == null)
			{
				PGJIAGGHBBA = new CJEAIHMINMJ();
			}
			PGJIAGGHBBA.MergeFrom(other.PGJIAGGHBBA);
			break;
		case HDACCIEIJFOOneofCase.MNIMAFBIGGP:
			if (MNIMAFBIGGP == null)
			{
				MNIMAFBIGGP = new ONCIMHEMJDD();
			}
			MNIMAFBIGGP.MergeFrom(other.MNIMAFBIGGP);
			break;
		case HDACCIEIJFOOneofCase.PPJOJOKOOBF:
			if (PPJOJOKOOBF == null)
			{
				PPJOJOKOOBF = new OJOLPAEPBDN();
			}
			PPJOJOKOOBF.MergeFrom(other.PPJOJOKOOBF);
			break;
		case HDACCIEIJFOOneofCase.BJGDFMJDJMH:
			if (BJGDFMJDJMH == null)
			{
				BJGDFMJDJMH = new KJBGALBCAEG();
			}
			BJGDFMJDJMH.MergeFrom(other.BJGDFMJDJMH);
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
			case 18u:
			{
				CJEAIHMINMJ cJEAIHMINMJ = new CJEAIHMINMJ();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PGJIAGGHBBA)
				{
					cJEAIHMINMJ.MergeFrom(PGJIAGGHBBA);
				}
				input.ReadMessage(cJEAIHMINMJ);
				PGJIAGGHBBA = cJEAIHMINMJ;
				break;
			}
			case 26u:
			{
				ONCIMHEMJDD oNCIMHEMJDD = new ONCIMHEMJDD();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.MNIMAFBIGGP)
				{
					oNCIMHEMJDD.MergeFrom(MNIMAFBIGGP);
				}
				input.ReadMessage(oNCIMHEMJDD);
				MNIMAFBIGGP = oNCIMHEMJDD;
				break;
			}
			case 82u:
			{
				OJOLPAEPBDN oJOLPAEPBDN = new OJOLPAEPBDN();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.PPJOJOKOOBF)
				{
					oJOLPAEPBDN.MergeFrom(PPJOJOKOOBF);
				}
				input.ReadMessage(oJOLPAEPBDN);
				PPJOJOKOOBF = oJOLPAEPBDN;
				break;
			}
			case 106u:
			{
				KJBGALBCAEG kJBGALBCAEG = new KJBGALBCAEG();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.BJGDFMJDJMH)
				{
					kJBGALBCAEG.MergeFrom(BJGDFMJDJMH);
				}
				input.ReadMessage(kJBGALBCAEG);
				BJGDFMJDJMH = kJBGALBCAEG;
				break;
			}
			}
		}
	}
}
