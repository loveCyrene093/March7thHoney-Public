using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHNGIOFDJNL : IMessage<AHNGIOFDJNL>, IMessage, IEquatable<AHNGIOFDJNL>, IDeepCloneable<AHNGIOFDJNL>, IBufferMessage
{
	private static readonly MessageParser<AHNGIOFDJNL> _parser = new MessageParser<AHNGIOFDJNL>(() => new AHNGIOFDJNL());

	private UnknownFieldSet _unknownFields;

	public const int BFHJHAKFBIGFieldNumber = 2;

	private static readonly FieldCodec<MAGHEFEELAB> _repeated_bFHJHAKFBIG_codec = FieldCodec.ForMessage(18u, MAGHEFEELAB.Parser);

	private readonly RepeatedField<MAGHEFEELAB> bFHJHAKFBIG_ = new RepeatedField<MAGHEFEELAB>();

	public const int NDGDEKEAFCCFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_nDGDEKEAFCC_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> nDGDEKEAFCC_ = new RepeatedField<uint>();

	public const int StoryInfoFieldNumber = 7;

	private BGKDOOJAHAM storyInfo_;

	public const int JJAABLCMFLPFieldNumber = 9;

	private static readonly FieldCodec<PNCBGGJKKAF> _repeated_jJAABLCMFLP_codec = FieldCodec.ForMessage(74u, PNCBGGJKKAF.Parser);

	private readonly RepeatedField<PNCBGGJKKAF> jJAABLCMFLP_ = new RepeatedField<PNCBGGJKKAF>();

	public const int NIPCEAFLCAAFieldNumber = 11;

	private static readonly FieldCodec<NDPGKDLGBFB> _repeated_nIPCEAFLCAA_codec = FieldCodec.ForMessage(90u, NDPGKDLGBFB.Parser);

	private readonly RepeatedField<NDPGKDLGBFB> nIPCEAFLCAA_ = new RepeatedField<NDPGKDLGBFB>();

	public const int CLLGHDCNPOIFieldNumber = 13;

	private KJAGLIIDBGP cLLGHDCNPOI_;

	public const int BICPNKOCHGNFieldNumber = 15;

	private static readonly FieldCodec<NJINCNAGALP> _repeated_bICPNKOCHGN_codec = FieldCodec.ForMessage(122u, NJINCNAGALP.Parser);

	private readonly RepeatedField<NJINCNAGALP> bICPNKOCHGN_ = new RepeatedField<NJINCNAGALP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHNGIOFDJNL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHNGIOFDJNLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MAGHEFEELAB> BFHJHAKFBIG => bFHJHAKFBIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NDGDEKEAFCC => nDGDEKEAFCC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKDOOJAHAM StoryInfo
	{
		get
		{
			return storyInfo_;
		}
		set
		{
			storyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PNCBGGJKKAF> JJAABLCMFLP => jJAABLCMFLP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NDPGKDLGBFB> NIPCEAFLCAA => nIPCEAFLCAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJAGLIIDBGP CLLGHDCNPOI
	{
		get
		{
			return cLLGHDCNPOI_;
		}
		set
		{
			cLLGHDCNPOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NJINCNAGALP> BICPNKOCHGN => bICPNKOCHGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHNGIOFDJNL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHNGIOFDJNL(AHNGIOFDJNL other)
		: this()
	{
		bFHJHAKFBIG_ = other.bFHJHAKFBIG_.Clone();
		nDGDEKEAFCC_ = other.nDGDEKEAFCC_.Clone();
		storyInfo_ = ((other.storyInfo_ != null) ? other.storyInfo_.Clone() : null);
		jJAABLCMFLP_ = other.jJAABLCMFLP_.Clone();
		nIPCEAFLCAA_ = other.nIPCEAFLCAA_.Clone();
		cLLGHDCNPOI_ = ((other.cLLGHDCNPOI_ != null) ? other.cLLGHDCNPOI_.Clone() : null);
		bICPNKOCHGN_ = other.bICPNKOCHGN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHNGIOFDJNL Clone()
	{
		return new AHNGIOFDJNL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHNGIOFDJNL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHNGIOFDJNL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bFHJHAKFBIG_.Equals(other.bFHJHAKFBIG_))
		{
			return false;
		}
		if (!nDGDEKEAFCC_.Equals(other.nDGDEKEAFCC_))
		{
			return false;
		}
		if (!object.Equals(StoryInfo, other.StoryInfo))
		{
			return false;
		}
		if (!jJAABLCMFLP_.Equals(other.jJAABLCMFLP_))
		{
			return false;
		}
		if (!nIPCEAFLCAA_.Equals(other.nIPCEAFLCAA_))
		{
			return false;
		}
		if (!object.Equals(CLLGHDCNPOI, other.CLLGHDCNPOI))
		{
			return false;
		}
		if (!bICPNKOCHGN_.Equals(other.bICPNKOCHGN_))
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
		num ^= bFHJHAKFBIG_.GetHashCode();
		num ^= nDGDEKEAFCC_.GetHashCode();
		if (storyInfo_ != null)
		{
			num ^= StoryInfo.GetHashCode();
		}
		num ^= jJAABLCMFLP_.GetHashCode();
		num ^= nIPCEAFLCAA_.GetHashCode();
		if (cLLGHDCNPOI_ != null)
		{
			num ^= CLLGHDCNPOI.GetHashCode();
		}
		num ^= bICPNKOCHGN_.GetHashCode();
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
		bFHJHAKFBIG_.WriteTo(ref output, _repeated_bFHJHAKFBIG_codec);
		nDGDEKEAFCC_.WriteTo(ref output, _repeated_nDGDEKEAFCC_codec);
		if (storyInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(StoryInfo);
		}
		jJAABLCMFLP_.WriteTo(ref output, _repeated_jJAABLCMFLP_codec);
		nIPCEAFLCAA_.WriteTo(ref output, _repeated_nIPCEAFLCAA_codec);
		if (cLLGHDCNPOI_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(CLLGHDCNPOI);
		}
		bICPNKOCHGN_.WriteTo(ref output, _repeated_bICPNKOCHGN_codec);
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
		num += bFHJHAKFBIG_.CalculateSize(_repeated_bFHJHAKFBIG_codec);
		num += nDGDEKEAFCC_.CalculateSize(_repeated_nDGDEKEAFCC_codec);
		if (storyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoryInfo);
		}
		num += jJAABLCMFLP_.CalculateSize(_repeated_jJAABLCMFLP_codec);
		num += nIPCEAFLCAA_.CalculateSize(_repeated_nIPCEAFLCAA_codec);
		if (cLLGHDCNPOI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLLGHDCNPOI);
		}
		num += bICPNKOCHGN_.CalculateSize(_repeated_bICPNKOCHGN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AHNGIOFDJNL other)
	{
		if (other == null)
		{
			return;
		}
		bFHJHAKFBIG_.Add(other.bFHJHAKFBIG_);
		nDGDEKEAFCC_.Add(other.nDGDEKEAFCC_);
		if (other.storyInfo_ != null)
		{
			if (storyInfo_ == null)
			{
				StoryInfo = new BGKDOOJAHAM();
			}
			StoryInfo.MergeFrom(other.StoryInfo);
		}
		jJAABLCMFLP_.Add(other.jJAABLCMFLP_);
		nIPCEAFLCAA_.Add(other.nIPCEAFLCAA_);
		if (other.cLLGHDCNPOI_ != null)
		{
			if (cLLGHDCNPOI_ == null)
			{
				CLLGHDCNPOI = new KJAGLIIDBGP();
			}
			CLLGHDCNPOI.MergeFrom(other.CLLGHDCNPOI);
		}
		bICPNKOCHGN_.Add(other.bICPNKOCHGN_);
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
				bFHJHAKFBIG_.AddEntriesFrom(ref input, _repeated_bFHJHAKFBIG_codec);
				break;
			case 40u:
			case 42u:
				nDGDEKEAFCC_.AddEntriesFrom(ref input, _repeated_nDGDEKEAFCC_codec);
				break;
			case 58u:
				if (storyInfo_ == null)
				{
					StoryInfo = new BGKDOOJAHAM();
				}
				input.ReadMessage(StoryInfo);
				break;
			case 74u:
				jJAABLCMFLP_.AddEntriesFrom(ref input, _repeated_jJAABLCMFLP_codec);
				break;
			case 90u:
				nIPCEAFLCAA_.AddEntriesFrom(ref input, _repeated_nIPCEAFLCAA_codec);
				break;
			case 106u:
				if (cLLGHDCNPOI_ == null)
				{
					CLLGHDCNPOI = new KJAGLIIDBGP();
				}
				input.ReadMessage(CLLGHDCNPOI);
				break;
			case 122u:
				bICPNKOCHGN_.AddEntriesFrom(ref input, _repeated_bICPNKOCHGN_codec);
				break;
			}
		}
	}
}
