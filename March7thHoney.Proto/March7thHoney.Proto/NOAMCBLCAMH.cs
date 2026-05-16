using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOAMCBLCAMH : IMessage<NOAMCBLCAMH>, IMessage, IEquatable<NOAMCBLCAMH>, IDeepCloneable<NOAMCBLCAMH>, IBufferMessage
{
	private static readonly MessageParser<NOAMCBLCAMH> _parser = new MessageParser<NOAMCBLCAMH>(() => new NOAMCBLCAMH());

	private UnknownFieldSet _unknownFields;

	public const int CCAHGLDMHGIFieldNumber = 2;

	private OHAOFLALHBL cCAHGLDMHGI_;

	public const int QuestListFieldNumber = 12;

	private static readonly FieldCodec<GCACHJFLGHH> _repeated_questList_codec = FieldCodec.ForMessage(98u, GCACHJFLGHH.Parser);

	private readonly RepeatedField<GCACHJFLGHH> questList_ = new RepeatedField<GCACHJFLGHH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOAMCBLCAMH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOAMCBLCAMHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHAOFLALHBL CCAHGLDMHGI
	{
		get
		{
			return cCAHGLDMHGI_;
		}
		set
		{
			cCAHGLDMHGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GCACHJFLGHH> QuestList => questList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOAMCBLCAMH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOAMCBLCAMH(NOAMCBLCAMH other)
		: this()
	{
		cCAHGLDMHGI_ = ((other.cCAHGLDMHGI_ != null) ? other.cCAHGLDMHGI_.Clone() : null);
		questList_ = other.questList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOAMCBLCAMH Clone()
	{
		return new NOAMCBLCAMH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOAMCBLCAMH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOAMCBLCAMH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CCAHGLDMHGI, other.CCAHGLDMHGI))
		{
			return false;
		}
		if (!questList_.Equals(other.questList_))
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
		if (cCAHGLDMHGI_ != null)
		{
			num ^= CCAHGLDMHGI.GetHashCode();
		}
		num ^= questList_.GetHashCode();
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
		if (cCAHGLDMHGI_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CCAHGLDMHGI);
		}
		questList_.WriteTo(ref output, _repeated_questList_codec);
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
		if (cCAHGLDMHGI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CCAHGLDMHGI);
		}
		num += questList_.CalculateSize(_repeated_questList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NOAMCBLCAMH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cCAHGLDMHGI_ != null)
		{
			if (cCAHGLDMHGI_ == null)
			{
				CCAHGLDMHGI = new OHAOFLALHBL();
			}
			CCAHGLDMHGI.MergeFrom(other.CCAHGLDMHGI);
		}
		questList_.Add(other.questList_);
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
				if (cCAHGLDMHGI_ == null)
				{
					CCAHGLDMHGI = new OHAOFLALHBL();
				}
				input.ReadMessage(CCAHGLDMHGI);
				break;
			case 98u:
				questList_.AddEntriesFrom(ref input, _repeated_questList_codec);
				break;
			}
		}
	}
}
