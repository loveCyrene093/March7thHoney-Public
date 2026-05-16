using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDFOGMAMFGF : IMessage<CDFOGMAMFGF>, IMessage, IEquatable<CDFOGMAMFGF>, IDeepCloneable<CDFOGMAMFGF>, IBufferMessage
{
	private static readonly MessageParser<CDFOGMAMFGF> _parser = new MessageParser<CDFOGMAMFGF>(() => new CDFOGMAMFGF());

	private UnknownFieldSet _unknownFields;

	public const int CGLIPMIMMJGFieldNumber = 1;

	private static readonly FieldCodec<NEIIDDAMPGL> _repeated_cGLIPMIMMJG_codec = FieldCodec.ForMessage(10u, NEIIDDAMPGL.Parser);

	private readonly RepeatedField<NEIIDDAMPGL> cGLIPMIMMJG_ = new RepeatedField<NEIIDDAMPGL>();

	public const int PLMHAPPKLGAFieldNumber = 7;

	private HDNOFFGMDNJ pLMHAPPKLGA_;

	public const int CurIndexFieldNumber = 9;

	private uint curIndex_;

	public const int BMNDBKBHIOCFieldNumber = 15;

	private HDNOFFGMDNJ bMNDBKBHIOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDFOGMAMFGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDFOGMAMFGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NEIIDDAMPGL> CGLIPMIMMJG => cGLIPMIMMJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDNOFFGMDNJ PLMHAPPKLGA
	{
		get
		{
			return pLMHAPPKLGA_;
		}
		set
		{
			pLMHAPPKLGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurIndex
	{
		get
		{
			return curIndex_;
		}
		set
		{
			curIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDNOFFGMDNJ BMNDBKBHIOC
	{
		get
		{
			return bMNDBKBHIOC_;
		}
		set
		{
			bMNDBKBHIOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDFOGMAMFGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDFOGMAMFGF(CDFOGMAMFGF other)
		: this()
	{
		cGLIPMIMMJG_ = other.cGLIPMIMMJG_.Clone();
		pLMHAPPKLGA_ = ((other.pLMHAPPKLGA_ != null) ? other.pLMHAPPKLGA_.Clone() : null);
		curIndex_ = other.curIndex_;
		bMNDBKBHIOC_ = ((other.bMNDBKBHIOC_ != null) ? other.bMNDBKBHIOC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDFOGMAMFGF Clone()
	{
		return new CDFOGMAMFGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDFOGMAMFGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDFOGMAMFGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cGLIPMIMMJG_.Equals(other.cGLIPMIMMJG_))
		{
			return false;
		}
		if (!object.Equals(PLMHAPPKLGA, other.PLMHAPPKLGA))
		{
			return false;
		}
		if (CurIndex != other.CurIndex)
		{
			return false;
		}
		if (!object.Equals(BMNDBKBHIOC, other.BMNDBKBHIOC))
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
		num ^= cGLIPMIMMJG_.GetHashCode();
		if (pLMHAPPKLGA_ != null)
		{
			num ^= PLMHAPPKLGA.GetHashCode();
		}
		if (CurIndex != 0)
		{
			num ^= CurIndex.GetHashCode();
		}
		if (bMNDBKBHIOC_ != null)
		{
			num ^= BMNDBKBHIOC.GetHashCode();
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
		cGLIPMIMMJG_.WriteTo(ref output, _repeated_cGLIPMIMMJG_codec);
		if (pLMHAPPKLGA_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PLMHAPPKLGA);
		}
		if (CurIndex != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurIndex);
		}
		if (bMNDBKBHIOC_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BMNDBKBHIOC);
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
		num += cGLIPMIMMJG_.CalculateSize(_repeated_cGLIPMIMMJG_codec);
		if (pLMHAPPKLGA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLMHAPPKLGA);
		}
		if (CurIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurIndex);
		}
		if (bMNDBKBHIOC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMNDBKBHIOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CDFOGMAMFGF other)
	{
		if (other == null)
		{
			return;
		}
		cGLIPMIMMJG_.Add(other.cGLIPMIMMJG_);
		if (other.pLMHAPPKLGA_ != null)
		{
			if (pLMHAPPKLGA_ == null)
			{
				PLMHAPPKLGA = new HDNOFFGMDNJ();
			}
			PLMHAPPKLGA.MergeFrom(other.PLMHAPPKLGA);
		}
		if (other.CurIndex != 0)
		{
			CurIndex = other.CurIndex;
		}
		if (other.bMNDBKBHIOC_ != null)
		{
			if (bMNDBKBHIOC_ == null)
			{
				BMNDBKBHIOC = new HDNOFFGMDNJ();
			}
			BMNDBKBHIOC.MergeFrom(other.BMNDBKBHIOC);
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
				cGLIPMIMMJG_.AddEntriesFrom(ref input, _repeated_cGLIPMIMMJG_codec);
				break;
			case 58u:
				if (pLMHAPPKLGA_ == null)
				{
					PLMHAPPKLGA = new HDNOFFGMDNJ();
				}
				input.ReadMessage(PLMHAPPKLGA);
				break;
			case 72u:
				CurIndex = input.ReadUInt32();
				break;
			case 122u:
				if (bMNDBKBHIOC_ == null)
				{
					BMNDBKBHIOC = new HDNOFFGMDNJ();
				}
				input.ReadMessage(BMNDBKBHIOC);
				break;
			}
		}
	}
}
