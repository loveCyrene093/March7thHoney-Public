using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCHLAEEOBIF : IMessage<NCHLAEEOBIF>, IMessage, IEquatable<NCHLAEEOBIF>, IDeepCloneable<NCHLAEEOBIF>, IBufferMessage
{
	private static readonly MessageParser<NCHLAEEOBIF> _parser = new MessageParser<NCHLAEEOBIF>(() => new NCHLAEEOBIF());

	private UnknownFieldSet _unknownFields;

	public const int JAAHELCLHMIFieldNumber = 1;

	private EFEGKDHEMFN jAAHELCLHMI_;

	public const int GMDHPHLIMAGFieldNumber = 2;

	private static readonly MapField<uint, uint>.Codec _map_gMDHPHLIMAG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<uint, uint> gMDHPHLIMAG_ = new MapField<uint, uint>();

	public const int EBFBLMKIOAIFieldNumber = 3;

	private uint eBFBLMKIOAI_;

	public const int BFNPCJOMGFLFieldNumber = 4;

	private EFEGKDHEMFN bFNPCJOMGFL_;

	public const int IAAAADCLFLFFieldNumber = 6;

	private uint iAAAADCLFLF_;

	public const int EMGENIILJMCFieldNumber = 7;

	private uint eMGENIILJMC_;

	public const int OGODDOIGOJEFieldNumber = 8;

	private EFEGKDHEMFN oGODDOIGOJE_;

	public const int JPGFLKDLOOPFieldNumber = 13;

	private uint jPGFLKDLOOP_;

	public const int MMNOLIMBPCAFieldNumber = 14;

	private static readonly FieldCodec<CNLIKADPCBH> _repeated_mMNOLIMBPCA_codec = FieldCodec.ForMessage(114u, CNLIKADPCBH.Parser);

	private readonly RepeatedField<CNLIKADPCBH> mMNOLIMBPCA_ = new RepeatedField<CNLIKADPCBH>();

	public const int OPBCCIBECMIFieldNumber = 15;

	private uint oPBCCIBECMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCHLAEEOBIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCHLAEEOBIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN JAAHELCLHMI
	{
		get
		{
			return jAAHELCLHMI_;
		}
		set
		{
			jAAHELCLHMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> GMDHPHLIMAG => gMDHPHLIMAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EBFBLMKIOAI
	{
		get
		{
			return eBFBLMKIOAI_;
		}
		set
		{
			eBFBLMKIOAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN BFNPCJOMGFL
	{
		get
		{
			return bFNPCJOMGFL_;
		}
		set
		{
			bFNPCJOMGFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAAAADCLFLF
	{
		get
		{
			return iAAAADCLFLF_;
		}
		set
		{
			iAAAADCLFLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMGENIILJMC
	{
		get
		{
			return eMGENIILJMC_;
		}
		set
		{
			eMGENIILJMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN OGODDOIGOJE
	{
		get
		{
			return oGODDOIGOJE_;
		}
		set
		{
			oGODDOIGOJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPGFLKDLOOP
	{
		get
		{
			return jPGFLKDLOOP_;
		}
		set
		{
			jPGFLKDLOOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CNLIKADPCBH> MMNOLIMBPCA => mMNOLIMBPCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPBCCIBECMI
	{
		get
		{
			return oPBCCIBECMI_;
		}
		set
		{
			oPBCCIBECMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLAEEOBIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLAEEOBIF(NCHLAEEOBIF other)
		: this()
	{
		jAAHELCLHMI_ = ((other.jAAHELCLHMI_ != null) ? other.jAAHELCLHMI_.Clone() : null);
		gMDHPHLIMAG_ = other.gMDHPHLIMAG_.Clone();
		eBFBLMKIOAI_ = other.eBFBLMKIOAI_;
		bFNPCJOMGFL_ = ((other.bFNPCJOMGFL_ != null) ? other.bFNPCJOMGFL_.Clone() : null);
		iAAAADCLFLF_ = other.iAAAADCLFLF_;
		eMGENIILJMC_ = other.eMGENIILJMC_;
		oGODDOIGOJE_ = ((other.oGODDOIGOJE_ != null) ? other.oGODDOIGOJE_.Clone() : null);
		jPGFLKDLOOP_ = other.jPGFLKDLOOP_;
		mMNOLIMBPCA_ = other.mMNOLIMBPCA_.Clone();
		oPBCCIBECMI_ = other.oPBCCIBECMI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLAEEOBIF Clone()
	{
		return new NCHLAEEOBIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCHLAEEOBIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCHLAEEOBIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JAAHELCLHMI, other.JAAHELCLHMI))
		{
			return false;
		}
		if (!GMDHPHLIMAG.Equals(other.GMDHPHLIMAG))
		{
			return false;
		}
		if (EBFBLMKIOAI != other.EBFBLMKIOAI)
		{
			return false;
		}
		if (!object.Equals(BFNPCJOMGFL, other.BFNPCJOMGFL))
		{
			return false;
		}
		if (IAAAADCLFLF != other.IAAAADCLFLF)
		{
			return false;
		}
		if (EMGENIILJMC != other.EMGENIILJMC)
		{
			return false;
		}
		if (!object.Equals(OGODDOIGOJE, other.OGODDOIGOJE))
		{
			return false;
		}
		if (JPGFLKDLOOP != other.JPGFLKDLOOP)
		{
			return false;
		}
		if (!mMNOLIMBPCA_.Equals(other.mMNOLIMBPCA_))
		{
			return false;
		}
		if (OPBCCIBECMI != other.OPBCCIBECMI)
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
		if (jAAHELCLHMI_ != null)
		{
			num ^= JAAHELCLHMI.GetHashCode();
		}
		num ^= GMDHPHLIMAG.GetHashCode();
		if (EBFBLMKIOAI != 0)
		{
			num ^= EBFBLMKIOAI.GetHashCode();
		}
		if (bFNPCJOMGFL_ != null)
		{
			num ^= BFNPCJOMGFL.GetHashCode();
		}
		if (IAAAADCLFLF != 0)
		{
			num ^= IAAAADCLFLF.GetHashCode();
		}
		if (EMGENIILJMC != 0)
		{
			num ^= EMGENIILJMC.GetHashCode();
		}
		if (oGODDOIGOJE_ != null)
		{
			num ^= OGODDOIGOJE.GetHashCode();
		}
		if (JPGFLKDLOOP != 0)
		{
			num ^= JPGFLKDLOOP.GetHashCode();
		}
		num ^= mMNOLIMBPCA_.GetHashCode();
		if (OPBCCIBECMI != 0)
		{
			num ^= OPBCCIBECMI.GetHashCode();
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
		if (jAAHELCLHMI_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JAAHELCLHMI);
		}
		gMDHPHLIMAG_.WriteTo(ref output, _map_gMDHPHLIMAG_codec);
		if (EBFBLMKIOAI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EBFBLMKIOAI);
		}
		if (bFNPCJOMGFL_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BFNPCJOMGFL);
		}
		if (IAAAADCLFLF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IAAAADCLFLF);
		}
		if (EMGENIILJMC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EMGENIILJMC);
		}
		if (oGODDOIGOJE_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OGODDOIGOJE);
		}
		if (JPGFLKDLOOP != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JPGFLKDLOOP);
		}
		mMNOLIMBPCA_.WriteTo(ref output, _repeated_mMNOLIMBPCA_codec);
		if (OPBCCIBECMI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OPBCCIBECMI);
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
		if (jAAHELCLHMI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JAAHELCLHMI);
		}
		num += gMDHPHLIMAG_.CalculateSize(_map_gMDHPHLIMAG_codec);
		if (EBFBLMKIOAI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EBFBLMKIOAI);
		}
		if (bFNPCJOMGFL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BFNPCJOMGFL);
		}
		if (IAAAADCLFLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAAAADCLFLF);
		}
		if (EMGENIILJMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMGENIILJMC);
		}
		if (oGODDOIGOJE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OGODDOIGOJE);
		}
		if (JPGFLKDLOOP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPGFLKDLOOP);
		}
		num += mMNOLIMBPCA_.CalculateSize(_repeated_mMNOLIMBPCA_codec);
		if (OPBCCIBECMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPBCCIBECMI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCHLAEEOBIF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jAAHELCLHMI_ != null)
		{
			if (jAAHELCLHMI_ == null)
			{
				JAAHELCLHMI = new EFEGKDHEMFN();
			}
			JAAHELCLHMI.MergeFrom(other.JAAHELCLHMI);
		}
		gMDHPHLIMAG_.MergeFrom(other.gMDHPHLIMAG_);
		if (other.EBFBLMKIOAI != 0)
		{
			EBFBLMKIOAI = other.EBFBLMKIOAI;
		}
		if (other.bFNPCJOMGFL_ != null)
		{
			if (bFNPCJOMGFL_ == null)
			{
				BFNPCJOMGFL = new EFEGKDHEMFN();
			}
			BFNPCJOMGFL.MergeFrom(other.BFNPCJOMGFL);
		}
		if (other.IAAAADCLFLF != 0)
		{
			IAAAADCLFLF = other.IAAAADCLFLF;
		}
		if (other.EMGENIILJMC != 0)
		{
			EMGENIILJMC = other.EMGENIILJMC;
		}
		if (other.oGODDOIGOJE_ != null)
		{
			if (oGODDOIGOJE_ == null)
			{
				OGODDOIGOJE = new EFEGKDHEMFN();
			}
			OGODDOIGOJE.MergeFrom(other.OGODDOIGOJE);
		}
		if (other.JPGFLKDLOOP != 0)
		{
			JPGFLKDLOOP = other.JPGFLKDLOOP;
		}
		mMNOLIMBPCA_.Add(other.mMNOLIMBPCA_);
		if (other.OPBCCIBECMI != 0)
		{
			OPBCCIBECMI = other.OPBCCIBECMI;
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
			case 10u:
				if (jAAHELCLHMI_ == null)
				{
					JAAHELCLHMI = new EFEGKDHEMFN();
				}
				input.ReadMessage(JAAHELCLHMI);
				break;
			case 18u:
				gMDHPHLIMAG_.AddEntriesFrom(ref input, _map_gMDHPHLIMAG_codec);
				break;
			case 24u:
				EBFBLMKIOAI = input.ReadUInt32();
				break;
			case 34u:
				if (bFNPCJOMGFL_ == null)
				{
					BFNPCJOMGFL = new EFEGKDHEMFN();
				}
				input.ReadMessage(BFNPCJOMGFL);
				break;
			case 48u:
				IAAAADCLFLF = input.ReadUInt32();
				break;
			case 56u:
				EMGENIILJMC = input.ReadUInt32();
				break;
			case 66u:
				if (oGODDOIGOJE_ == null)
				{
					OGODDOIGOJE = new EFEGKDHEMFN();
				}
				input.ReadMessage(OGODDOIGOJE);
				break;
			case 104u:
				JPGFLKDLOOP = input.ReadUInt32();
				break;
			case 114u:
				mMNOLIMBPCA_.AddEntriesFrom(ref input, _repeated_mMNOLIMBPCA_codec);
				break;
			case 120u:
				OPBCCIBECMI = input.ReadUInt32();
				break;
			}
		}
	}
}
