using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2PvpFinishScNotify : IMessage<MatchThreeV2PvpFinishScNotify>, IMessage, IEquatable<MatchThreeV2PvpFinishScNotify>, IDeepCloneable<MatchThreeV2PvpFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2PvpFinishScNotify> _parser = new MessageParser<MatchThreeV2PvpFinishScNotify>(() => new MatchThreeV2PvpFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MHFHODDBOPMFieldNumber = 1;

	private ECKIDLIFAFG mHFHODDBOPM_;

	public const int BFCBGPEICHGFieldNumber = 4;

	private FightGameMode bFCBGPEICHG_;

	public const int IJDMECLJEBDFieldNumber = 6;

	private uint iJDMECLJEBD_;

	public const int KJHGGPEMPHMFieldNumber = 11;

	private NOJLPMLALPI kJHGGPEMPHM_;

	public const int DKAEIDJMJCJFieldNumber = 14;

	private uint dKAEIDJMJCJ_;

	public const int ReasonFieldNumber = 15;

	private FKANIBDJNKG reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2PvpFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2PvpFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG MHFHODDBOPM
	{
		get
		{
			return mHFHODDBOPM_;
		}
		set
		{
			mHFHODDBOPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode BFCBGPEICHG
	{
		get
		{
			return bFCBGPEICHG_;
		}
		set
		{
			bFCBGPEICHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJDMECLJEBD
	{
		get
		{
			return iJDMECLJEBD_;
		}
		set
		{
			iJDMECLJEBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJLPMLALPI KJHGGPEMPHM
	{
		get
		{
			return kJHGGPEMPHM_;
		}
		set
		{
			kJHGGPEMPHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKAEIDJMJCJ
	{
		get
		{
			return dKAEIDJMJCJ_;
		}
		set
		{
			dKAEIDJMJCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKANIBDJNKG Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2PvpFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2PvpFinishScNotify(MatchThreeV2PvpFinishScNotify other)
		: this()
	{
		mHFHODDBOPM_ = ((other.mHFHODDBOPM_ != null) ? other.mHFHODDBOPM_.Clone() : null);
		bFCBGPEICHG_ = other.bFCBGPEICHG_;
		iJDMECLJEBD_ = other.iJDMECLJEBD_;
		kJHGGPEMPHM_ = ((other.kJHGGPEMPHM_ != null) ? other.kJHGGPEMPHM_.Clone() : null);
		dKAEIDJMJCJ_ = other.dKAEIDJMJCJ_;
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2PvpFinishScNotify Clone()
	{
		return new MatchThreeV2PvpFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2PvpFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2PvpFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MHFHODDBOPM, other.MHFHODDBOPM))
		{
			return false;
		}
		if (BFCBGPEICHG != other.BFCBGPEICHG)
		{
			return false;
		}
		if (IJDMECLJEBD != other.IJDMECLJEBD)
		{
			return false;
		}
		if (!object.Equals(KJHGGPEMPHM, other.KJHGGPEMPHM))
		{
			return false;
		}
		if (DKAEIDJMJCJ != other.DKAEIDJMJCJ)
		{
			return false;
		}
		if (Reason != other.Reason)
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
		if (mHFHODDBOPM_ != null)
		{
			num ^= MHFHODDBOPM.GetHashCode();
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= BFCBGPEICHG.GetHashCode();
		}
		if (IJDMECLJEBD != 0)
		{
			num ^= IJDMECLJEBD.GetHashCode();
		}
		if (kJHGGPEMPHM_ != null)
		{
			num ^= KJHGGPEMPHM.GetHashCode();
		}
		if (DKAEIDJMJCJ != 0)
		{
			num ^= DKAEIDJMJCJ.GetHashCode();
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			num ^= Reason.GetHashCode();
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
		if (mHFHODDBOPM_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MHFHODDBOPM);
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BFCBGPEICHG);
		}
		if (IJDMECLJEBD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IJDMECLJEBD);
		}
		if (kJHGGPEMPHM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(KJHGGPEMPHM);
		}
		if (DKAEIDJMJCJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DKAEIDJMJCJ);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Reason);
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
		if (mHFHODDBOPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHFHODDBOPM);
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BFCBGPEICHG);
		}
		if (IJDMECLJEBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJDMECLJEBD);
		}
		if (kJHGGPEMPHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJHGGPEMPHM);
		}
		if (DKAEIDJMJCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKAEIDJMJCJ);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2PvpFinishScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mHFHODDBOPM_ != null)
		{
			if (mHFHODDBOPM_ == null)
			{
				MHFHODDBOPM = new ECKIDLIFAFG();
			}
			MHFHODDBOPM.MergeFrom(other.MHFHODDBOPM);
		}
		if (other.BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			BFCBGPEICHG = other.BFCBGPEICHG;
		}
		if (other.IJDMECLJEBD != 0)
		{
			IJDMECLJEBD = other.IJDMECLJEBD;
		}
		if (other.kJHGGPEMPHM_ != null)
		{
			if (kJHGGPEMPHM_ == null)
			{
				KJHGGPEMPHM = new NOJLPMLALPI();
			}
			KJHGGPEMPHM.MergeFrom(other.KJHGGPEMPHM);
		}
		if (other.DKAEIDJMJCJ != 0)
		{
			DKAEIDJMJCJ = other.DKAEIDJMJCJ;
		}
		if (other.Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			Reason = other.Reason;
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
				if (mHFHODDBOPM_ == null)
				{
					MHFHODDBOPM = new ECKIDLIFAFG();
				}
				input.ReadMessage(MHFHODDBOPM);
				break;
			case 32u:
				BFCBGPEICHG = (FightGameMode)input.ReadEnum();
				break;
			case 48u:
				IJDMECLJEBD = input.ReadUInt32();
				break;
			case 90u:
				if (kJHGGPEMPHM_ == null)
				{
					KJHGGPEMPHM = new NOJLPMLALPI();
				}
				input.ReadMessage(KJHGGPEMPHM);
				break;
			case 112u:
				DKAEIDJMJCJ = input.ReadUInt32();
				break;
			case 120u:
				Reason = (FKANIBDJNKG)input.ReadEnum();
				break;
			}
		}
	}
}
