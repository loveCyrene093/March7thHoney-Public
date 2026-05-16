using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournGetMiscRealTimeDataScRsp : IMessage<RogueTournGetMiscRealTimeDataScRsp>, IMessage, IEquatable<RogueTournGetMiscRealTimeDataScRsp>, IDeepCloneable<RogueTournGetMiscRealTimeDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournGetMiscRealTimeDataScRsp> _parser = new MessageParser<RogueTournGetMiscRealTimeDataScRsp>(() => new RogueTournGetMiscRealTimeDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LOIIMDAEMIOFieldNumber = 6;

	private CFOIFABCGAE lOIIMDAEMIO_;

	public const int NOCNEOMKFIOFieldNumber = 7;

	private KKMPEHIFMNC nOCNEOMKFIO_;

	public const int PBDGFDJHIICFieldNumber = 8;

	private ENEHKONPJNA pBDGFDJHIIC_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int KOCGKEAFLCBFieldNumber = 12;

	private OKBFGNELFMG kOCGKEAFLCB_;

	public const int AAPIPKPJEFMFieldNumber = 13;

	private NAKPLIGJELP aAPIPKPJEFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournGetMiscRealTimeDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFOIFABCGAE LOIIMDAEMIO
	{
		get
		{
			return lOIIMDAEMIO_;
		}
		set
		{
			lOIIMDAEMIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKMPEHIFMNC NOCNEOMKFIO
	{
		get
		{
			return nOCNEOMKFIO_;
		}
		set
		{
			nOCNEOMKFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEHKONPJNA PBDGFDJHIIC
	{
		get
		{
			return pBDGFDJHIIC_;
		}
		set
		{
			pBDGFDJHIIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKBFGNELFMG KOCGKEAFLCB
	{
		get
		{
			return kOCGKEAFLCB_;
		}
		set
		{
			kOCGKEAFLCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP AAPIPKPJEFM
	{
		get
		{
			return aAPIPKPJEFM_;
		}
		set
		{
			aAPIPKPJEFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetMiscRealTimeDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetMiscRealTimeDataScRsp(RogueTournGetMiscRealTimeDataScRsp other)
		: this()
	{
		lOIIMDAEMIO_ = ((other.lOIIMDAEMIO_ != null) ? other.lOIIMDAEMIO_.Clone() : null);
		nOCNEOMKFIO_ = ((other.nOCNEOMKFIO_ != null) ? other.nOCNEOMKFIO_.Clone() : null);
		pBDGFDJHIIC_ = ((other.pBDGFDJHIIC_ != null) ? other.pBDGFDJHIIC_.Clone() : null);
		retcode_ = other.retcode_;
		kOCGKEAFLCB_ = ((other.kOCGKEAFLCB_ != null) ? other.kOCGKEAFLCB_.Clone() : null);
		aAPIPKPJEFM_ = ((other.aAPIPKPJEFM_ != null) ? other.aAPIPKPJEFM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetMiscRealTimeDataScRsp Clone()
	{
		return new RogueTournGetMiscRealTimeDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournGetMiscRealTimeDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournGetMiscRealTimeDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LOIIMDAEMIO, other.LOIIMDAEMIO))
		{
			return false;
		}
		if (!object.Equals(NOCNEOMKFIO, other.NOCNEOMKFIO))
		{
			return false;
		}
		if (!object.Equals(PBDGFDJHIIC, other.PBDGFDJHIIC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(KOCGKEAFLCB, other.KOCGKEAFLCB))
		{
			return false;
		}
		if (!object.Equals(AAPIPKPJEFM, other.AAPIPKPJEFM))
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
		if (lOIIMDAEMIO_ != null)
		{
			num ^= LOIIMDAEMIO.GetHashCode();
		}
		if (nOCNEOMKFIO_ != null)
		{
			num ^= NOCNEOMKFIO.GetHashCode();
		}
		if (pBDGFDJHIIC_ != null)
		{
			num ^= PBDGFDJHIIC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (kOCGKEAFLCB_ != null)
		{
			num ^= KOCGKEAFLCB.GetHashCode();
		}
		if (aAPIPKPJEFM_ != null)
		{
			num ^= AAPIPKPJEFM.GetHashCode();
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
		if (lOIIMDAEMIO_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LOIIMDAEMIO);
		}
		if (nOCNEOMKFIO_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NOCNEOMKFIO);
		}
		if (pBDGFDJHIIC_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PBDGFDJHIIC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (kOCGKEAFLCB_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(KOCGKEAFLCB);
		}
		if (aAPIPKPJEFM_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(AAPIPKPJEFM);
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
		if (lOIIMDAEMIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LOIIMDAEMIO);
		}
		if (nOCNEOMKFIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOCNEOMKFIO);
		}
		if (pBDGFDJHIIC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PBDGFDJHIIC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (kOCGKEAFLCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KOCGKEAFLCB);
		}
		if (aAPIPKPJEFM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AAPIPKPJEFM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournGetMiscRealTimeDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lOIIMDAEMIO_ != null)
		{
			if (lOIIMDAEMIO_ == null)
			{
				LOIIMDAEMIO = new CFOIFABCGAE();
			}
			LOIIMDAEMIO.MergeFrom(other.LOIIMDAEMIO);
		}
		if (other.nOCNEOMKFIO_ != null)
		{
			if (nOCNEOMKFIO_ == null)
			{
				NOCNEOMKFIO = new KKMPEHIFMNC();
			}
			NOCNEOMKFIO.MergeFrom(other.NOCNEOMKFIO);
		}
		if (other.pBDGFDJHIIC_ != null)
		{
			if (pBDGFDJHIIC_ == null)
			{
				PBDGFDJHIIC = new ENEHKONPJNA();
			}
			PBDGFDJHIIC.MergeFrom(other.PBDGFDJHIIC);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.kOCGKEAFLCB_ != null)
		{
			if (kOCGKEAFLCB_ == null)
			{
				KOCGKEAFLCB = new OKBFGNELFMG();
			}
			KOCGKEAFLCB.MergeFrom(other.KOCGKEAFLCB);
		}
		if (other.aAPIPKPJEFM_ != null)
		{
			if (aAPIPKPJEFM_ == null)
			{
				AAPIPKPJEFM = new NAKPLIGJELP();
			}
			AAPIPKPJEFM.MergeFrom(other.AAPIPKPJEFM);
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
			case 50u:
				if (lOIIMDAEMIO_ == null)
				{
					LOIIMDAEMIO = new CFOIFABCGAE();
				}
				input.ReadMessage(LOIIMDAEMIO);
				break;
			case 58u:
				if (nOCNEOMKFIO_ == null)
				{
					NOCNEOMKFIO = new KKMPEHIFMNC();
				}
				input.ReadMessage(NOCNEOMKFIO);
				break;
			case 66u:
				if (pBDGFDJHIIC_ == null)
				{
					PBDGFDJHIIC = new ENEHKONPJNA();
				}
				input.ReadMessage(PBDGFDJHIIC);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (kOCGKEAFLCB_ == null)
				{
					KOCGKEAFLCB = new OKBFGNELFMG();
				}
				input.ReadMessage(KOCGKEAFLCB);
				break;
			case 106u:
				if (aAPIPKPJEFM_ == null)
				{
					AAPIPKPJEFM = new NAKPLIGJELP();
				}
				input.ReadMessage(AAPIPKPJEFM);
				break;
			}
		}
	}
}
