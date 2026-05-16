using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MotionInfo : IMessage<MotionInfo>, IMessage, IEquatable<MotionInfo>, IDeepCloneable<MotionInfo>, IBufferMessage
{
	private static readonly MessageParser<MotionInfo> _parser = new MessageParser<MotionInfo>(() => new MotionInfo());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 7;

	private Vector pos_;

	public const int RotFieldNumber = 8;

	private Vector rot_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MotionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MotionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector Pos
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
	public Vector Rot
	{
		get
		{
			return rot_;
		}
		set
		{
			rot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo(MotionInfo other)
		: this()
	{
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Clone()
	{
		return new MotionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MotionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MotionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (!object.Equals(Rot, other.Rot))
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
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (rot_ != null)
		{
			num ^= Rot.GetHashCode();
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
		if (pos_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Pos);
		}
		if (rot_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Rot);
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
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (rot_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Rot);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MotionInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new Vector();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.rot_ != null)
		{
			if (rot_ == null)
			{
				Rot = new Vector();
			}
			Rot.MergeFrom(other.Rot);
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
			case 58u:
				if (pos_ == null)
				{
					Pos = new Vector();
				}
				input.ReadMessage(Pos);
				break;
			case 66u:
				if (rot_ == null)
				{
					Rot = new Vector();
				}
				input.ReadMessage(Rot);
				break;
			}
		}
	}
}
