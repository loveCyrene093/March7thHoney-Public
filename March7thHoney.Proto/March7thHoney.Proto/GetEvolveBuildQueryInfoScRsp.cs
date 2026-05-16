using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetEvolveBuildQueryInfoScRsp : IMessage<GetEvolveBuildQueryInfoScRsp>, IMessage, IEquatable<GetEvolveBuildQueryInfoScRsp>, IDeepCloneable<GetEvolveBuildQueryInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetEvolveBuildQueryInfoScRsp> _parser = new MessageParser<GetEvolveBuildQueryInfoScRsp>(() => new GetEvolveBuildQueryInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HLLEIPKMJKMFieldNumber = 4;

	private static readonly FieldCodec<CJLJDKLCNDA> _repeated_hLLEIPKMJKM_codec = FieldCodec.ForMessage(34u, CJLJDKLCNDA.Parser);

	private readonly RepeatedField<CJLJDKLCNDA> hLLEIPKMJKM_ = new RepeatedField<CJLJDKLCNDA>();

	public const int OIAPHBBDPHLFieldNumber = 14;

	private JCFPONBDCLG oIAPHBBDPHL_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetEvolveBuildQueryInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetEvolveBuildQueryInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CJLJDKLCNDA> HLLEIPKMJKM => hLLEIPKMJKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFPONBDCLG OIAPHBBDPHL
	{
		get
		{
			return oIAPHBBDPHL_;
		}
		set
		{
			oIAPHBBDPHL_ = value;
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
	public GetEvolveBuildQueryInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildQueryInfoScRsp(GetEvolveBuildQueryInfoScRsp other)
		: this()
	{
		hLLEIPKMJKM_ = other.hLLEIPKMJKM_.Clone();
		oIAPHBBDPHL_ = ((other.oIAPHBBDPHL_ != null) ? other.oIAPHBBDPHL_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildQueryInfoScRsp Clone()
	{
		return new GetEvolveBuildQueryInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetEvolveBuildQueryInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetEvolveBuildQueryInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hLLEIPKMJKM_.Equals(other.hLLEIPKMJKM_))
		{
			return false;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= hLLEIPKMJKM_.GetHashCode();
		if (oIAPHBBDPHL_ != null)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		hLLEIPKMJKM_.WriteTo(ref output, _repeated_hLLEIPKMJKM_codec);
		if (oIAPHBBDPHL_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		num += hLLEIPKMJKM_.CalculateSize(_repeated_hLLEIPKMJKM_codec);
		if (oIAPHBBDPHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetEvolveBuildQueryInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		hLLEIPKMJKM_.Add(other.hLLEIPKMJKM_);
		if (other.oIAPHBBDPHL_ != null)
		{
			if (oIAPHBBDPHL_ == null)
			{
				OIAPHBBDPHL = new JCFPONBDCLG();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 34u:
				hLLEIPKMJKM_.AddEntriesFrom(ref input, _repeated_hLLEIPKMJKM_codec);
				break;
			case 114u:
				if (oIAPHBBDPHL_ == null)
				{
					OIAPHBBDPHL = new JCFPONBDCLG();
				}
				input.ReadMessage(OIAPHBBDPHL);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
