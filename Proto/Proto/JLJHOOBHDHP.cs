using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLJHOOBHDHP : IMessage<JLJHOOBHDHP>, IMessage, IEquatable<JLJHOOBHDHP>, IDeepCloneable<JLJHOOBHDHP>, IBufferMessage
{
	private static readonly MessageParser<JLJHOOBHDHP> _parser = new MessageParser<JLJHOOBHDHP>(() => new JLJHOOBHDHP());

	private UnknownFieldSet _unknownFields;

	public const int GroupStateInfoFieldNumber = 4;

	private GroupStateInfo groupStateInfo_;

	public const int IdFieldNumber = 8;

	private uint id_;

	public const int MotionFieldNumber = 9;

	private MotionInfo motion_;

	public const int LCHAHECJPOIFieldNumber = 10;

	private bool lCHAHECJPOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLJHOOBHDHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLJHOOBHDHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStateInfo GroupStateInfo
	{
		get
		{
			return groupStateInfo_;
		}
		set
		{
			groupStateInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LCHAHECJPOI
	{
		get
		{
			return lCHAHECJPOI_;
		}
		set
		{
			lCHAHECJPOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLJHOOBHDHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLJHOOBHDHP(JLJHOOBHDHP other)
		: this()
	{
		groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
		id_ = other.id_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		lCHAHECJPOI_ = other.lCHAHECJPOI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLJHOOBHDHP Clone()
	{
		return new JLJHOOBHDHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLJHOOBHDHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLJHOOBHDHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GroupStateInfo, other.GroupStateInfo))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
		{
			return false;
		}
		if (LCHAHECJPOI != other.LCHAHECJPOI)
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
		if (groupStateInfo_ != null)
		{
			num ^= GroupStateInfo.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (LCHAHECJPOI)
		{
			num ^= LCHAHECJPOI.GetHashCode();
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
		if (groupStateInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GroupStateInfo);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Id);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Motion);
		}
		if (LCHAHECJPOI)
		{
			output.WriteRawTag(80);
			output.WriteBool(LCHAHECJPOI);
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
		if (groupStateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GroupStateInfo);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (LCHAHECJPOI)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLJHOOBHDHP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.groupStateInfo_ != null)
		{
			if (groupStateInfo_ == null)
			{
				GroupStateInfo = new GroupStateInfo();
			}
			GroupStateInfo.MergeFrom(other.GroupStateInfo);
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.LCHAHECJPOI)
		{
			LCHAHECJPOI = other.LCHAHECJPOI;
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
				if (groupStateInfo_ == null)
				{
					GroupStateInfo = new GroupStateInfo();
				}
				input.ReadMessage(GroupStateInfo);
				break;
			case 64u:
				Id = input.ReadUInt32();
				break;
			case 74u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 80u:
				LCHAHECJPOI = input.ReadBool();
				break;
			}
		}
	}
}
