using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOJNMAIACGB : IMessage<NOJNMAIACGB>, IMessage, IEquatable<NOJNMAIACGB>, IDeepCloneable<NOJNMAIACGB>, IBufferMessage
{
	private static readonly MessageParser<NOJNMAIACGB> _parser = new MessageParser<NOJNMAIACGB>(() => new NOJNMAIACGB());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 1;

	private int uniqueId_;

	public const int PosFieldNumber = 7;

	private AGBLLFGOBKE pos_;

	public const int FGMLMKKCMJMFieldNumber = 11;

	private uint fGMLMKKCMJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOJNMAIACGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOJNMAIACGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGMLMKKCMJM
	{
		get
		{
			return fGMLMKKCMJM_;
		}
		set
		{
			fGMLMKKCMJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJNMAIACGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJNMAIACGB(NOJNMAIACGB other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		fGMLMKKCMJM_ = other.fGMLMKKCMJM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJNMAIACGB Clone()
	{
		return new NOJNMAIACGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOJNMAIACGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOJNMAIACGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (FGMLMKKCMJM != other.FGMLMKKCMJM)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (FGMLMKKCMJM != 0)
		{
			num ^= FGMLMKKCMJM.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UniqueId);
		}
		if (pos_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Pos);
		}
		if (FGMLMKKCMJM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FGMLMKKCMJM);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueId);
		}
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (FGMLMKKCMJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGMLMKKCMJM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NOJNMAIACGB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new AGBLLFGOBKE();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.FGMLMKKCMJM != 0)
		{
			FGMLMKKCMJM = other.FGMLMKKCMJM;
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
			case 8u:
				UniqueId = input.ReadInt32();
				break;
			case 58u:
				if (pos_ == null)
				{
					Pos = new AGBLLFGOBKE();
				}
				input.ReadMessage(Pos);
				break;
			case 88u:
				FGMLMKKCMJM = input.ReadUInt32();
				break;
			}
		}
	}
}
