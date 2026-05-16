using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelfRankChangeNtf : IMessage<SelfRankChangeNtf>, IMessage, IEquatable<SelfRankChangeNtf>, IDeepCloneable<SelfRankChangeNtf>, IBufferMessage
{
	private static readonly MessageParser<SelfRankChangeNtf> _parser = new MessageParser<SelfRankChangeNtf>(() => new SelfRankChangeNtf());

	private UnknownFieldSet _unknownFields;

	public const int PLOBMBFPNFKFieldNumber = 1;

	private FightGameMode pLOBMBFPNFK_;

	public const int CPBGLNGOCBAFieldNumber = 14;

	private static readonly FieldCodec<EFBIHJHMICB> _repeated_cPBGLNGOCBA_codec = FieldCodec.ForMessage(114u, EFBIHJHMICB.Parser);

	private readonly RepeatedField<EFBIHJHMICB> cPBGLNGOCBA_ = new RepeatedField<EFBIHJHMICB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelfRankChangeNtf> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelfRankChangeNtfReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EFBIHJHMICB> CPBGLNGOCBA => cPBGLNGOCBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelfRankChangeNtf()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelfRankChangeNtf(SelfRankChangeNtf other)
		: this()
	{
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		cPBGLNGOCBA_ = other.cPBGLNGOCBA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelfRankChangeNtf Clone()
	{
		return new SelfRankChangeNtf(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelfRankChangeNtf);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelfRankChangeNtf other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (!cPBGLNGOCBA_.Equals(other.cPBGLNGOCBA_))
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		num ^= cPBGLNGOCBA_.GetHashCode();
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		cPBGLNGOCBA_.WriteTo(ref output, _repeated_cPBGLNGOCBA_codec);
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		num += cPBGLNGOCBA_.CalculateSize(_repeated_cPBGLNGOCBA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelfRankChangeNtf other)
	{
		if (other != null)
		{
			if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
			{
				PLOBMBFPNFK = other.PLOBMBFPNFK;
			}
			cPBGLNGOCBA_.Add(other.cPBGLNGOCBA_);
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
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			case 114u:
				cPBGLNGOCBA_.AddEntriesFrom(ref input, _repeated_cPBGLNGOCBA_codec);
				break;
			}
		}
	}
}
