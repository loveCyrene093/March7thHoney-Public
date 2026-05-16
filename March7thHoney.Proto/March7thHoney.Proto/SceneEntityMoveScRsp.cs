using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityMoveScRsp : IMessage<SceneEntityMoveScRsp>, IMessage, IEquatable<SceneEntityMoveScRsp>, IDeepCloneable<SceneEntityMoveScRsp>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityMoveScRsp> _parser = new MessageParser<SceneEntityMoveScRsp>(() => new SceneEntityMoveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DownloadDataFieldNumber = 6;

	private ClientDownloadData downloadData_;

	public const int EntityMotionListFieldNumber = 11;

	private static readonly FieldCodec<EntityMotion> _repeated_entityMotionList_codec = FieldCodec.ForMessage(90u, EntityMotion.Parser);

	private readonly RepeatedField<EntityMotion> entityMotionList_ = new RepeatedField<EntityMotion>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityMoveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityMoveScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData DownloadData
	{
		get
		{
			return downloadData_;
		}
		set
		{
			downloadData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EntityMotion> EntityMotionList => entityMotionList_;

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
	public SceneEntityMoveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveScRsp(SceneEntityMoveScRsp other)
		: this()
	{
		downloadData_ = ((other.downloadData_ != null) ? other.downloadData_.Clone() : null);
		entityMotionList_ = other.entityMotionList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveScRsp Clone()
	{
		return new SceneEntityMoveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityMoveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityMoveScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DownloadData, other.DownloadData))
		{
			return false;
		}
		if (!entityMotionList_.Equals(other.entityMotionList_))
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
		if (downloadData_ != null)
		{
			num ^= DownloadData.GetHashCode();
		}
		num ^= entityMotionList_.GetHashCode();
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
		if (downloadData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DownloadData);
		}
		entityMotionList_.WriteTo(ref output, _repeated_entityMotionList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (downloadData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DownloadData);
		}
		num += entityMotionList_.CalculateSize(_repeated_entityMotionList_codec);
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
	public void MergeFrom(SceneEntityMoveScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.downloadData_ != null)
		{
			if (downloadData_ == null)
			{
				DownloadData = new ClientDownloadData();
			}
			DownloadData.MergeFrom(other.DownloadData);
		}
		entityMotionList_.Add(other.entityMotionList_);
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
			case 50u:
				if (downloadData_ == null)
				{
					DownloadData = new ClientDownloadData();
				}
				input.ReadMessage(DownloadData);
				break;
			case 90u:
				entityMotionList_.AddEntriesFrom(ref input, _repeated_entityMotionList_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
