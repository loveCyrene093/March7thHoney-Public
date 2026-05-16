using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NNKJBNNANJK : IMessage<NNKJBNNANJK>, IMessage, IEquatable<NNKJBNNANJK>, IDeepCloneable<NNKJBNNANJK>, IBufferMessage
{
	private static readonly MessageParser<NNKJBNNANJK> _parser = new MessageParser<NNKJBNNANJK>(() => new NNKJBNNANJK());

	private UnknownFieldSet _unknownFields;

	public const int TurnCounterFieldNumber = 1;

	private uint turnCounter_;

	public const int PEBGNFPGJMAFieldNumber = 2;

	private uint pEBGNFPGJMA_;

	public const int ILPPFOAPIIMFieldNumber = 3;

	private uint iLPPFOAPIIM_;

	public const int JFJPJIJLAOGFieldNumber = 4;

	private static readonly FieldCodec<PLGDKFFNDIB> _repeated_jFJPJIJLAOG_codec = FieldCodec.ForMessage(34u, PLGDKFFNDIB.Parser);

	private readonly RepeatedField<PLGDKFFNDIB> jFJPJIJLAOG_ = new RepeatedField<PLGDKFFNDIB>();

	public const int KDABKNDHMJLFieldNumber = 5;

	private static readonly FieldCodec<AMDMHJPPCNF> _repeated_kDABKNDHMJL_codec = FieldCodec.ForMessage(42u, AMDMHJPPCNF.Parser);

	private readonly RepeatedField<AMDMHJPPCNF> kDABKNDHMJL_ = new RepeatedField<AMDMHJPPCNF>();

	public const int GGEFGLBMMKPFieldNumber = 6;

	private uint gGEFGLBMMKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NNKJBNNANJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NNKJBNNANJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TurnCounter
	{
		get
		{
			return turnCounter_;
		}
		set
		{
			turnCounter_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEBGNFPGJMA
	{
		get
		{
			return pEBGNFPGJMA_;
		}
		set
		{
			pEBGNFPGJMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILPPFOAPIIM
	{
		get
		{
			return iLPPFOAPIIM_;
		}
		set
		{
			iLPPFOAPIIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PLGDKFFNDIB> JFJPJIJLAOG => jFJPJIJLAOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AMDMHJPPCNF> KDABKNDHMJL => kDABKNDHMJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGEFGLBMMKP
	{
		get
		{
			return gGEFGLBMMKP_;
		}
		set
		{
			gGEFGLBMMKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNKJBNNANJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNKJBNNANJK(NNKJBNNANJK other)
		: this()
	{
		turnCounter_ = other.turnCounter_;
		pEBGNFPGJMA_ = other.pEBGNFPGJMA_;
		iLPPFOAPIIM_ = other.iLPPFOAPIIM_;
		jFJPJIJLAOG_ = other.jFJPJIJLAOG_.Clone();
		kDABKNDHMJL_ = other.kDABKNDHMJL_.Clone();
		gGEFGLBMMKP_ = other.gGEFGLBMMKP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNKJBNNANJK Clone()
	{
		return new NNKJBNNANJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NNKJBNNANJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NNKJBNNANJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TurnCounter != other.TurnCounter)
		{
			return false;
		}
		if (PEBGNFPGJMA != other.PEBGNFPGJMA)
		{
			return false;
		}
		if (ILPPFOAPIIM != other.ILPPFOAPIIM)
		{
			return false;
		}
		if (!jFJPJIJLAOG_.Equals(other.jFJPJIJLAOG_))
		{
			return false;
		}
		if (!kDABKNDHMJL_.Equals(other.kDABKNDHMJL_))
		{
			return false;
		}
		if (GGEFGLBMMKP != other.GGEFGLBMMKP)
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
		if (TurnCounter != 0)
		{
			num ^= TurnCounter.GetHashCode();
		}
		if (PEBGNFPGJMA != 0)
		{
			num ^= PEBGNFPGJMA.GetHashCode();
		}
		if (ILPPFOAPIIM != 0)
		{
			num ^= ILPPFOAPIIM.GetHashCode();
		}
		num ^= jFJPJIJLAOG_.GetHashCode();
		num ^= kDABKNDHMJL_.GetHashCode();
		if (GGEFGLBMMKP != 0)
		{
			num ^= GGEFGLBMMKP.GetHashCode();
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
		if (TurnCounter != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TurnCounter);
		}
		if (PEBGNFPGJMA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PEBGNFPGJMA);
		}
		if (ILPPFOAPIIM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ILPPFOAPIIM);
		}
		jFJPJIJLAOG_.WriteTo(ref output, _repeated_jFJPJIJLAOG_codec);
		kDABKNDHMJL_.WriteTo(ref output, _repeated_kDABKNDHMJL_codec);
		if (GGEFGLBMMKP != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GGEFGLBMMKP);
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
		if (TurnCounter != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnCounter);
		}
		if (PEBGNFPGJMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEBGNFPGJMA);
		}
		if (ILPPFOAPIIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILPPFOAPIIM);
		}
		num += jFJPJIJLAOG_.CalculateSize(_repeated_jFJPJIJLAOG_codec);
		num += kDABKNDHMJL_.CalculateSize(_repeated_kDABKNDHMJL_codec);
		if (GGEFGLBMMKP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGEFGLBMMKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NNKJBNNANJK other)
	{
		if (other != null)
		{
			if (other.TurnCounter != 0)
			{
				TurnCounter = other.TurnCounter;
			}
			if (other.PEBGNFPGJMA != 0)
			{
				PEBGNFPGJMA = other.PEBGNFPGJMA;
			}
			if (other.ILPPFOAPIIM != 0)
			{
				ILPPFOAPIIM = other.ILPPFOAPIIM;
			}
			jFJPJIJLAOG_.Add(other.jFJPJIJLAOG_);
			kDABKNDHMJL_.Add(other.kDABKNDHMJL_);
			if (other.GGEFGLBMMKP != 0)
			{
				GGEFGLBMMKP = other.GGEFGLBMMKP;
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
			case 8u:
				TurnCounter = input.ReadUInt32();
				break;
			case 16u:
				PEBGNFPGJMA = input.ReadUInt32();
				break;
			case 24u:
				ILPPFOAPIIM = input.ReadUInt32();
				break;
			case 34u:
				jFJPJIJLAOG_.AddEntriesFrom(ref input, _repeated_jFJPJIJLAOG_codec);
				break;
			case 42u:
				kDABKNDHMJL_.AddEntriesFrom(ref input, _repeated_kDABKNDHMJL_codec);
				break;
			case 48u:
				GGEFGLBMMKP = input.ReadUInt32();
				break;
			}
		}
	}
}
