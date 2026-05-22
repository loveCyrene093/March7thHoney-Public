using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateGroupPropertyScRsp : IMessage<UpdateGroupPropertyScRsp>, IMessage, IEquatable<UpdateGroupPropertyScRsp>, IDeepCloneable<UpdateGroupPropertyScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpdateGroupPropertyScRsp> _parser = new MessageParser<UpdateGroupPropertyScRsp>(() => new UpdateGroupPropertyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 2;

	private uint groupId_;

	public const int DimensionIdFieldNumber = 3;

	private uint dimensionId_;

	public const int ELKOCIJNABKFieldNumber = 5;

	private int eLKOCIJNABK_;

	public const int FloorIdFieldNumber = 6;

	private uint floorId_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int ELNCJFFJFIHFieldNumber = 10;

	private string eLNCJFFJFIH_ = "";

	public const int FNAODNGJAMMFieldNumber = 12;

	private int fNAODNGJAMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateGroupPropertyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateGroupPropertyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DimensionId
	{
		get
		{
			return dimensionId_;
		}
		set
		{
			dimensionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ELKOCIJNABK
	{
		get
		{
			return eLKOCIJNABK_;
		}
		set
		{
			eLKOCIJNABK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
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
	public string ELNCJFFJFIH
	{
		get
		{
			return eLNCJFFJFIH_;
		}
		set
		{
			eLNCJFFJFIH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FNAODNGJAMM
	{
		get
		{
			return fNAODNGJAMM_;
		}
		set
		{
			fNAODNGJAMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyScRsp(UpdateGroupPropertyScRsp other)
		: this()
	{
		groupId_ = other.groupId_;
		dimensionId_ = other.dimensionId_;
		eLKOCIJNABK_ = other.eLKOCIJNABK_;
		floorId_ = other.floorId_;
		retcode_ = other.retcode_;
		eLNCJFFJFIH_ = other.eLNCJFFJFIH_;
		fNAODNGJAMM_ = other.fNAODNGJAMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGroupPropertyScRsp Clone()
	{
		return new UpdateGroupPropertyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateGroupPropertyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateGroupPropertyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (DimensionId != other.DimensionId)
		{
			return false;
		}
		if (ELKOCIJNABK != other.ELKOCIJNABK)
		{
			return false;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ELNCJFFJFIH != other.ELNCJFFJFIH)
		{
			return false;
		}
		if (FNAODNGJAMM != other.FNAODNGJAMM)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		if (ELKOCIJNABK != 0)
		{
			num ^= ELKOCIJNABK.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num ^= ELNCJFFJFIH.GetHashCode();
		}
		if (FNAODNGJAMM != 0)
		{
			num ^= FNAODNGJAMM.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupId);
		}
		if (DimensionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DimensionId);
		}
		if (ELKOCIJNABK != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ELKOCIJNABK);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FloorId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(ELNCJFFJFIH);
		}
		if (FNAODNGJAMM != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(FNAODNGJAMM);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		if (ELKOCIJNABK != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ELKOCIJNABK);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ELNCJFFJFIH);
		}
		if (FNAODNGJAMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FNAODNGJAMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateGroupPropertyScRsp other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.DimensionId != 0)
			{
				DimensionId = other.DimensionId;
			}
			if (other.ELKOCIJNABK != 0)
			{
				ELKOCIJNABK = other.ELKOCIJNABK;
			}
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ELNCJFFJFIH.Length != 0)
			{
				ELNCJFFJFIH = other.ELNCJFFJFIH;
			}
			if (other.FNAODNGJAMM != 0)
			{
				FNAODNGJAMM = other.FNAODNGJAMM;
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
			case 16u:
				GroupId = input.ReadUInt32();
				break;
			case 24u:
				DimensionId = input.ReadUInt32();
				break;
			case 40u:
				ELKOCIJNABK = input.ReadInt32();
				break;
			case 48u:
				FloorId = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				ELNCJFFJFIH = input.ReadString();
				break;
			case 96u:
				FNAODNGJAMM = input.ReadInt32();
				break;
			}
		}
	}
}
