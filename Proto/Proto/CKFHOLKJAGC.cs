using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CKFHOLKJAGC : IMessage<CKFHOLKJAGC>, IMessage, IEquatable<CKFHOLKJAGC>, IDeepCloneable<CKFHOLKJAGC>, IBufferMessage
{
	private static readonly MessageParser<CKFHOLKJAGC> _parser = new MessageParser<CKFHOLKJAGC>(() => new CKFHOLKJAGC());

	private UnknownFieldSet _unknownFields;

	public const int HHNJKINLAJHFieldNumber = 1;

	private uint hHNJKINLAJH_;

	public const int DEBMOGCGMLIFieldNumber = 12;

	private uint dEBMOGCGMLI_;

	public const int MaxScoreFieldNumber = 14;

	private uint maxScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CKFHOLKJAGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CKFHOLKJAGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HHNJKINLAJH
	{
		get
		{
			return hHNJKINLAJH_;
		}
		set
		{
			hHNJKINLAJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEBMOGCGMLI
	{
		get
		{
			return dEBMOGCGMLI_;
		}
		set
		{
			dEBMOGCGMLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKFHOLKJAGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKFHOLKJAGC(CKFHOLKJAGC other)
		: this()
	{
		hHNJKINLAJH_ = other.hHNJKINLAJH_;
		dEBMOGCGMLI_ = other.dEBMOGCGMLI_;
		maxScore_ = other.maxScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKFHOLKJAGC Clone()
	{
		return new CKFHOLKJAGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CKFHOLKJAGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CKFHOLKJAGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HHNJKINLAJH != other.HHNJKINLAJH)
		{
			return false;
		}
		if (DEBMOGCGMLI != other.DEBMOGCGMLI)
		{
			return false;
		}
		if (MaxScore != other.MaxScore)
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
		if (HHNJKINLAJH != 0)
		{
			num ^= HHNJKINLAJH.GetHashCode();
		}
		if (DEBMOGCGMLI != 0)
		{
			num ^= DEBMOGCGMLI.GetHashCode();
		}
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
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
		if (HHNJKINLAJH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HHNJKINLAJH);
		}
		if (DEBMOGCGMLI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DEBMOGCGMLI);
		}
		if (MaxScore != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MaxScore);
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
		if (HHNJKINLAJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HHNJKINLAJH);
		}
		if (DEBMOGCGMLI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEBMOGCGMLI);
		}
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CKFHOLKJAGC other)
	{
		if (other != null)
		{
			if (other.HHNJKINLAJH != 0)
			{
				HHNJKINLAJH = other.HHNJKINLAJH;
			}
			if (other.DEBMOGCGMLI != 0)
			{
				DEBMOGCGMLI = other.DEBMOGCGMLI;
			}
			if (other.MaxScore != 0)
			{
				MaxScore = other.MaxScore;
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
				HHNJKINLAJH = input.ReadUInt32();
				break;
			case 96u:
				DEBMOGCGMLI = input.ReadUInt32();
				break;
			case 112u:
				MaxScore = input.ReadUInt32();
				break;
			}
		}
	}
}
