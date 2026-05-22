using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityRefreshInfo : IMessage<SceneEntityRefreshInfo>, IMessage, IEquatable<SceneEntityRefreshInfo>, IDeepCloneable<SceneEntityRefreshInfo>, IBufferMessage
{
	public enum RefreshTypeOneofCase
	{
		None = 0,
		HBIEDAJFELO = 4,
		DeleteEntity = 12,
		AddEntity = 14
	}

	private static readonly MessageParser<SceneEntityRefreshInfo> _parser = new MessageParser<SceneEntityRefreshInfo>(() => new SceneEntityRefreshInfo());

	private UnknownFieldSet _unknownFields;

	public const int HBIEDAJFELOFieldNumber = 4;

	public const int DeleteEntityFieldNumber = 12;

	public const int AddEntityFieldNumber = 14;

	private object refreshType_;

	private RefreshTypeOneofCase refreshTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityRefreshInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityRefreshInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBIEDAJFELO
	{
		get
		{
			if (!HasHBIEDAJFELO)
			{
				return 0u;
			}
			return (uint)refreshType_;
		}
		set
		{
			refreshType_ = value;
			refreshTypeCase_ = RefreshTypeOneofCase.HBIEDAJFELO;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHBIEDAJFELO => refreshTypeCase_ == RefreshTypeOneofCase.HBIEDAJFELO;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DeleteEntity
	{
		get
		{
			if (!HasDeleteEntity)
			{
				return 0u;
			}
			return (uint)refreshType_;
		}
		set
		{
			refreshType_ = value;
			refreshTypeCase_ = RefreshTypeOneofCase.DeleteEntity;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeleteEntity => refreshTypeCase_ == RefreshTypeOneofCase.DeleteEntity;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityInfo AddEntity
	{
		get
		{
			if (refreshTypeCase_ != RefreshTypeOneofCase.AddEntity)
			{
				return null;
			}
			return (SceneEntityInfo)refreshType_;
		}
		set
		{
			refreshType_ = value;
			refreshTypeCase_ = ((value != null) ? RefreshTypeOneofCase.AddEntity : RefreshTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTypeOneofCase RefreshTypeCase => refreshTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityRefreshInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityRefreshInfo(SceneEntityRefreshInfo other)
		: this()
	{
		switch (other.RefreshTypeCase)
		{
		case RefreshTypeOneofCase.HBIEDAJFELO:
			HBIEDAJFELO = other.HBIEDAJFELO;
			break;
		case RefreshTypeOneofCase.DeleteEntity:
			DeleteEntity = other.DeleteEntity;
			break;
		case RefreshTypeOneofCase.AddEntity:
			AddEntity = other.AddEntity.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityRefreshInfo Clone()
	{
		return new SceneEntityRefreshInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHBIEDAJFELO()
	{
		if (HasHBIEDAJFELO)
		{
			ClearRefreshType();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDeleteEntity()
	{
		if (HasDeleteEntity)
		{
			ClearRefreshType();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRefreshType()
	{
		refreshTypeCase_ = RefreshTypeOneofCase.None;
		refreshType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityRefreshInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityRefreshInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBIEDAJFELO != other.HBIEDAJFELO)
		{
			return false;
		}
		if (DeleteEntity != other.DeleteEntity)
		{
			return false;
		}
		if (!object.Equals(AddEntity, other.AddEntity))
		{
			return false;
		}
		if (RefreshTypeCase != other.RefreshTypeCase)
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
		if (HasHBIEDAJFELO)
		{
			num ^= HBIEDAJFELO.GetHashCode();
		}
		if (HasDeleteEntity)
		{
			num ^= DeleteEntity.GetHashCode();
		}
		if (refreshTypeCase_ == RefreshTypeOneofCase.AddEntity)
		{
			num ^= AddEntity.GetHashCode();
		}
		num ^= (int)refreshTypeCase_;
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
		if (HasHBIEDAJFELO)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HBIEDAJFELO);
		}
		if (HasDeleteEntity)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DeleteEntity);
		}
		if (refreshTypeCase_ == RefreshTypeOneofCase.AddEntity)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AddEntity);
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
		if (HasHBIEDAJFELO)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBIEDAJFELO);
		}
		if (HasDeleteEntity)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DeleteEntity);
		}
		if (refreshTypeCase_ == RefreshTypeOneofCase.AddEntity)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AddEntity);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityRefreshInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.RefreshTypeCase)
		{
		case RefreshTypeOneofCase.HBIEDAJFELO:
			HBIEDAJFELO = other.HBIEDAJFELO;
			break;
		case RefreshTypeOneofCase.DeleteEntity:
			DeleteEntity = other.DeleteEntity;
			break;
		case RefreshTypeOneofCase.AddEntity:
			if (AddEntity == null)
			{
				AddEntity = new SceneEntityInfo();
			}
			AddEntity.MergeFrom(other.AddEntity);
			break;
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
			case 32u:
				HBIEDAJFELO = input.ReadUInt32();
				break;
			case 96u:
				DeleteEntity = input.ReadUInt32();
				break;
			case 114u:
			{
				SceneEntityInfo sceneEntityInfo = new SceneEntityInfo();
				if (refreshTypeCase_ == RefreshTypeOneofCase.AddEntity)
				{
					sceneEntityInfo.MergeFrom(AddEntity);
				}
				input.ReadMessage(sceneEntityInfo);
				AddEntity = sceneEntityInfo;
				break;
			}
			}
		}
	}
}
