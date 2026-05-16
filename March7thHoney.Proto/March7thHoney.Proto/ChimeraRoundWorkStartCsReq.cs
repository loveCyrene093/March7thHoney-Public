using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraRoundWorkStartCsReq : IMessage<ChimeraRoundWorkStartCsReq>, IMessage, IEquatable<ChimeraRoundWorkStartCsReq>, IDeepCloneable<ChimeraRoundWorkStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraRoundWorkStartCsReq> _parser = new MessageParser<ChimeraRoundWorkStartCsReq>(() => new ChimeraRoundWorkStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KMAFDFBJCJIFieldNumber = 2;

	private static readonly FieldCodec<PCAOLJLFPBA> _repeated_kMAFDFBJCJI_codec = FieldCodec.ForMessage(18u, PCAOLJLFPBA.Parser);

	private readonly RepeatedField<PCAOLJLFPBA> kMAFDFBJCJI_ = new RepeatedField<PCAOLJLFPBA>();

	public const int GHMJNDCAEEOFieldNumber = 7;

	private uint gHMJNDCAEEO_;

	public const int FIGJHMCEPOAFieldNumber = 8;

	private uint fIGJHMCEPOA_;

	public const int LineupFieldNumber = 14;

	private FHCCCHJHHKL lineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraRoundWorkStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraRoundWorkStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PCAOLJLFPBA> KMAFDFBJCJI => kMAFDFBJCJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GHMJNDCAEEO
	{
		get
		{
			return gHMJNDCAEEO_;
		}
		set
		{
			gHMJNDCAEEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIGJHMCEPOA
	{
		get
		{
			return fIGJHMCEPOA_;
		}
		set
		{
			fIGJHMCEPOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraRoundWorkStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraRoundWorkStartCsReq(ChimeraRoundWorkStartCsReq other)
		: this()
	{
		kMAFDFBJCJI_ = other.kMAFDFBJCJI_.Clone();
		gHMJNDCAEEO_ = other.gHMJNDCAEEO_;
		fIGJHMCEPOA_ = other.fIGJHMCEPOA_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraRoundWorkStartCsReq Clone()
	{
		return new ChimeraRoundWorkStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraRoundWorkStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraRoundWorkStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kMAFDFBJCJI_.Equals(other.kMAFDFBJCJI_))
		{
			return false;
		}
		if (GHMJNDCAEEO != other.GHMJNDCAEEO)
		{
			return false;
		}
		if (FIGJHMCEPOA != other.FIGJHMCEPOA)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
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
		num ^= kMAFDFBJCJI_.GetHashCode();
		if (GHMJNDCAEEO != 0)
		{
			num ^= GHMJNDCAEEO.GetHashCode();
		}
		if (FIGJHMCEPOA != 0)
		{
			num ^= FIGJHMCEPOA.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
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
		kMAFDFBJCJI_.WriteTo(ref output, _repeated_kMAFDFBJCJI_codec);
		if (GHMJNDCAEEO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GHMJNDCAEEO);
		}
		if (FIGJHMCEPOA != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FIGJHMCEPOA);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Lineup);
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
		num += kMAFDFBJCJI_.CalculateSize(_repeated_kMAFDFBJCJI_codec);
		if (GHMJNDCAEEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GHMJNDCAEEO);
		}
		if (FIGJHMCEPOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIGJHMCEPOA);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraRoundWorkStartCsReq other)
	{
		if (other == null)
		{
			return;
		}
		kMAFDFBJCJI_.Add(other.kMAFDFBJCJI_);
		if (other.GHMJNDCAEEO != 0)
		{
			GHMJNDCAEEO = other.GHMJNDCAEEO;
		}
		if (other.FIGJHMCEPOA != 0)
		{
			FIGJHMCEPOA = other.FIGJHMCEPOA;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new FHCCCHJHHKL();
			}
			Lineup.MergeFrom(other.Lineup);
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
				kMAFDFBJCJI_.AddEntriesFrom(ref input, _repeated_kMAFDFBJCJI_codec);
				break;
			case 56u:
				GHMJNDCAEEO = input.ReadUInt32();
				break;
			case 64u:
				FIGJHMCEPOA = input.ReadUInt32();
				break;
			case 114u:
				if (lineup_ == null)
				{
					Lineup = new FHCCCHJHHKL();
				}
				input.ReadMessage(Lineup);
				break;
			}
		}
	}
}
