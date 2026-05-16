using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRedPointStatusScNotify : IMessage<SetRedPointStatusScNotify>, IMessage, IEquatable<SetRedPointStatusScNotify>, IDeepCloneable<SetRedPointStatusScNotify>, IBufferMessage
{
	private static readonly MessageParser<SetRedPointStatusScNotify> _parser = new MessageParser<SetRedPointStatusScNotify>(() => new SetRedPointStatusScNotify());

	private UnknownFieldSet _unknownFields;

	public const int APMCKODEGBKFieldNumber = 1;

	private static readonly FieldCodec<FAJGLOFICEI> _repeated_aPMCKODEGBK_codec = FieldCodec.ForMessage(10u, FAJGLOFICEI.Parser);

	private readonly RepeatedField<FAJGLOFICEI> aPMCKODEGBK_ = new RepeatedField<FAJGLOFICEI>();

	public const int JMIENBBMPAGFieldNumber = 3;

	private uint jMIENBBMPAG_;

	public const int NFDAJHJDGOJFieldNumber = 8;

	private uint nFDAJHJDGOJ_;

	public const int ContentIdFieldNumber = 11;

	private uint contentId_;

	public const int UidFieldNumber = 14;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRedPointStatusScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRedPointStatusScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FAJGLOFICEI> APMCKODEGBK => aPMCKODEGBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMIENBBMPAG
	{
		get
		{
			return jMIENBBMPAG_;
		}
		set
		{
			jMIENBBMPAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFDAJHJDGOJ
	{
		get
		{
			return nFDAJHJDGOJ_;
		}
		set
		{
			nFDAJHJDGOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRedPointStatusScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRedPointStatusScNotify(SetRedPointStatusScNotify other)
		: this()
	{
		aPMCKODEGBK_ = other.aPMCKODEGBK_.Clone();
		jMIENBBMPAG_ = other.jMIENBBMPAG_;
		nFDAJHJDGOJ_ = other.nFDAJHJDGOJ_;
		contentId_ = other.contentId_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRedPointStatusScNotify Clone()
	{
		return new SetRedPointStatusScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRedPointStatusScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRedPointStatusScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aPMCKODEGBK_.Equals(other.aPMCKODEGBK_))
		{
			return false;
		}
		if (JMIENBBMPAG != other.JMIENBBMPAG)
		{
			return false;
		}
		if (NFDAJHJDGOJ != other.NFDAJHJDGOJ)
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		num ^= aPMCKODEGBK_.GetHashCode();
		if (JMIENBBMPAG != 0)
		{
			num ^= JMIENBBMPAG.GetHashCode();
		}
		if (NFDAJHJDGOJ != 0)
		{
			num ^= NFDAJHJDGOJ.GetHashCode();
		}
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		aPMCKODEGBK_.WriteTo(ref output, _repeated_aPMCKODEGBK_codec);
		if (JMIENBBMPAG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JMIENBBMPAG);
		}
		if (NFDAJHJDGOJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NFDAJHJDGOJ);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ContentId);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Uid);
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
		num += aPMCKODEGBK_.CalculateSize(_repeated_aPMCKODEGBK_codec);
		if (JMIENBBMPAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMIENBBMPAG);
		}
		if (NFDAJHJDGOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFDAJHJDGOJ);
		}
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetRedPointStatusScNotify other)
	{
		if (other != null)
		{
			aPMCKODEGBK_.Add(other.aPMCKODEGBK_);
			if (other.JMIENBBMPAG != 0)
			{
				JMIENBBMPAG = other.JMIENBBMPAG;
			}
			if (other.NFDAJHJDGOJ != 0)
			{
				NFDAJHJDGOJ = other.NFDAJHJDGOJ;
			}
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 10u:
				aPMCKODEGBK_.AddEntriesFrom(ref input, _repeated_aPMCKODEGBK_codec);
				break;
			case 24u:
				JMIENBBMPAG = input.ReadUInt32();
				break;
			case 64u:
				NFDAJHJDGOJ = input.ReadUInt32();
				break;
			case 88u:
				ContentId = input.ReadUInt32();
				break;
			case 112u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
