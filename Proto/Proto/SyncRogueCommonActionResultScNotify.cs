using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueCommonActionResultScNotify : IMessage<SyncRogueCommonActionResultScNotify>, IMessage, IEquatable<SyncRogueCommonActionResultScNotify>, IDeepCloneable<SyncRogueCommonActionResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueCommonActionResultScNotify> _parser = new MessageParser<SyncRogueCommonActionResultScNotify>(() => new SyncRogueCommonActionResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LOIDOGEENOBFieldNumber = 7;

	private uint lOIDOGEENOB_;

	public const int BEAEJDOGDBGFieldNumber = 10;

	private static readonly FieldCodec<DPFOHPLLOIJ> _repeated_bEAEJDOGDBG_codec = FieldCodec.ForMessage(82u, DPFOHPLLOIJ.Parser);

	private readonly RepeatedField<DPFOHPLLOIJ> bEAEJDOGDBG_ = new RepeatedField<DPFOHPLLOIJ>();

	public const int ANIADNFEMAHFieldNumber = 11;

	private static readonly FieldCodec<MOEOOOMLGCG> _repeated_aNIADNFEMAH_codec = FieldCodec.ForMessage(90u, MOEOOOMLGCG.Parser);

	private readonly RepeatedField<MOEOOOMLGCG> aNIADNFEMAH_ = new RepeatedField<MOEOOOMLGCG>();

	public const int HCPAHPCOEKKFieldNumber = 14;

	private FMFMGICMPCA hCPAHPCOEKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueCommonActionResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueCommonActionResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPFOHPLLOIJ> BEAEJDOGDBG => bEAEJDOGDBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MOEOOOMLGCG> ANIADNFEMAH => aNIADNFEMAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMFMGICMPCA HCPAHPCOEKK
	{
		get
		{
			return hCPAHPCOEKK_;
		}
		set
		{
			hCPAHPCOEKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonActionResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonActionResultScNotify(SyncRogueCommonActionResultScNotify other)
		: this()
	{
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		bEAEJDOGDBG_ = other.bEAEJDOGDBG_.Clone();
		aNIADNFEMAH_ = other.aNIADNFEMAH_.Clone();
		hCPAHPCOEKK_ = other.hCPAHPCOEKK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonActionResultScNotify Clone()
	{
		return new SyncRogueCommonActionResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueCommonActionResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueCommonActionResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (!bEAEJDOGDBG_.Equals(other.bEAEJDOGDBG_))
		{
			return false;
		}
		if (!aNIADNFEMAH_.Equals(other.aNIADNFEMAH_))
		{
			return false;
		}
		if (HCPAHPCOEKK != other.HCPAHPCOEKK)
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
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		num ^= bEAEJDOGDBG_.GetHashCode();
		num ^= aNIADNFEMAH_.GetHashCode();
		if (HCPAHPCOEKK != FMFMGICMPCA.Pcpdhelpkem)
		{
			num ^= HCPAHPCOEKK.GetHashCode();
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
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LOIDOGEENOB);
		}
		bEAEJDOGDBG_.WriteTo(ref output, _repeated_bEAEJDOGDBG_codec);
		aNIADNFEMAH_.WriteTo(ref output, _repeated_aNIADNFEMAH_codec);
		if (HCPAHPCOEKK != FMFMGICMPCA.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)HCPAHPCOEKK);
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
		if (LOIDOGEENOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		num += bEAEJDOGDBG_.CalculateSize(_repeated_bEAEJDOGDBG_codec);
		num += aNIADNFEMAH_.CalculateSize(_repeated_aNIADNFEMAH_codec);
		if (HCPAHPCOEKK != FMFMGICMPCA.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HCPAHPCOEKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueCommonActionResultScNotify other)
	{
		if (other != null)
		{
			if (other.LOIDOGEENOB != 0)
			{
				LOIDOGEENOB = other.LOIDOGEENOB;
			}
			bEAEJDOGDBG_.Add(other.bEAEJDOGDBG_);
			aNIADNFEMAH_.Add(other.aNIADNFEMAH_);
			if (other.HCPAHPCOEKK != FMFMGICMPCA.Pcpdhelpkem)
			{
				HCPAHPCOEKK = other.HCPAHPCOEKK;
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
			case 56u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 82u:
				bEAEJDOGDBG_.AddEntriesFrom(ref input, _repeated_bEAEJDOGDBG_codec);
				break;
			case 90u:
				aNIADNFEMAH_.AddEntriesFrom(ref input, _repeated_aNIADNFEMAH_codec);
				break;
			case 112u:
				HCPAHPCOEKK = (FMFMGICMPCA)input.ReadEnum();
				break;
			}
		}
	}
}
