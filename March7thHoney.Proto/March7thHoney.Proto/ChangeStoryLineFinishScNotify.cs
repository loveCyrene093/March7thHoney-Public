using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangeStoryLineFinishScNotify : IMessage<ChangeStoryLineFinishScNotify>, IMessage, IEquatable<ChangeStoryLineFinishScNotify>, IDeepCloneable<ChangeStoryLineFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChangeStoryLineFinishScNotify> _parser = new MessageParser<ChangeStoryLineFinishScNotify>(() => new ChangeStoryLineFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KHDNGFKOFLHFieldNumber = 4;

	private uint kHDNGFKOFLH_;

	public const int ActionFieldNumber = 5;

	private ChangeStoryLineAction action_;

	public const int GOHCEOLEHLGFieldNumber = 9;

	private bool gOHCEOLEHLG_;

	public const int CurStoryLineIdFieldNumber = 13;

	private uint curStoryLineId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChangeStoryLineFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChangeStoryLineFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDNGFKOFLH
	{
		get
		{
			return kHDNGFKOFLH_;
		}
		set
		{
			kHDNGFKOFLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeStoryLineAction Action
	{
		get
		{
			return action_;
		}
		set
		{
			action_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GOHCEOLEHLG
	{
		get
		{
			return gOHCEOLEHLG_;
		}
		set
		{
			gOHCEOLEHLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurStoryLineId
	{
		get
		{
			return curStoryLineId_;
		}
		set
		{
			curStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeStoryLineFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeStoryLineFinishScNotify(ChangeStoryLineFinishScNotify other)
		: this()
	{
		kHDNGFKOFLH_ = other.kHDNGFKOFLH_;
		action_ = other.action_;
		gOHCEOLEHLG_ = other.gOHCEOLEHLG_;
		curStoryLineId_ = other.curStoryLineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeStoryLineFinishScNotify Clone()
	{
		return new ChangeStoryLineFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChangeStoryLineFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChangeStoryLineFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHDNGFKOFLH != other.KHDNGFKOFLH)
		{
			return false;
		}
		if (Action != other.Action)
		{
			return false;
		}
		if (GOHCEOLEHLG != other.GOHCEOLEHLG)
		{
			return false;
		}
		if (CurStoryLineId != other.CurStoryLineId)
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
		if (KHDNGFKOFLH != 0)
		{
			num ^= KHDNGFKOFLH.GetHashCode();
		}
		if (Action != ChangeStoryLineAction.None)
		{
			num ^= Action.GetHashCode();
		}
		if (GOHCEOLEHLG)
		{
			num ^= GOHCEOLEHLG.GetHashCode();
		}
		if (CurStoryLineId != 0)
		{
			num ^= CurStoryLineId.GetHashCode();
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
		if (KHDNGFKOFLH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KHDNGFKOFLH);
		}
		if (Action != ChangeStoryLineAction.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Action);
		}
		if (GOHCEOLEHLG)
		{
			output.WriteRawTag(72);
			output.WriteBool(GOHCEOLEHLG);
		}
		if (CurStoryLineId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CurStoryLineId);
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
		if (KHDNGFKOFLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDNGFKOFLH);
		}
		if (Action != ChangeStoryLineAction.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Action);
		}
		if (GOHCEOLEHLG)
		{
			num += 2;
		}
		if (CurStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurStoryLineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangeStoryLineFinishScNotify other)
	{
		if (other != null)
		{
			if (other.KHDNGFKOFLH != 0)
			{
				KHDNGFKOFLH = other.KHDNGFKOFLH;
			}
			if (other.Action != ChangeStoryLineAction.None)
			{
				Action = other.Action;
			}
			if (other.GOHCEOLEHLG)
			{
				GOHCEOLEHLG = other.GOHCEOLEHLG;
			}
			if (other.CurStoryLineId != 0)
			{
				CurStoryLineId = other.CurStoryLineId;
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
			case 32u:
				KHDNGFKOFLH = input.ReadUInt32();
				break;
			case 40u:
				Action = (ChangeStoryLineAction)input.ReadEnum();
				break;
			case 72u:
				GOHCEOLEHLG = input.ReadBool();
				break;
			case 104u:
				CurStoryLineId = input.ReadUInt32();
				break;
			}
		}
	}
}
